using LiveSplit.Model;
using LiveSplit.UI.Components;
using LiveSplit.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

public class ResetChanceComponent : IComponent
{
    // This internal component does the actual heavy lifting. Whenever we want to do something
    // like display text, we will call the appropriate function on the internal component.
    protected InfoTextComponent InternalComponent { get; set; }

    // This is how we will access all the settings that the user has set.
    public ResetChanceSettings Settings { get; set; }

    // This object contains all of the current information about the splits, the timer, etc.
    protected LiveSplitState CurrentState { get; set; }

    public string ComponentName => "Reset Chance";

    public float HorizontalWidth => InternalComponent.HorizontalWidth;
    public float MinimumWidth => InternalComponent.MinimumWidth;
    public float VerticalHeight => InternalComponent.VerticalHeight;
    public float MinimumHeight => InternalComponent.MinimumHeight;

    public float PaddingTop => InternalComponent.PaddingTop;
    public float PaddingLeft => InternalComponent.PaddingLeft;
    public float PaddingBottom => InternalComponent.PaddingBottom;
    public float PaddingRight => InternalComponent.PaddingRight;

    // I'm going to be honest, I don't know what this is for, but I know we don't need it.
    public IDictionary<string, Action> ContextMenuControls => null;

    protected List<float> ResetChances {  get; set; }
    protected float CurrentResetChance { get; set; }

    protected bool ResetChancesValid { get; set; }
    protected bool CurrentSplitValid { get; set; }

    // This function is called when LiveSplit creates your component. This happens when the
    // component is added to the layout, or when LiveSplit opens a layout with this component
    // already added.
    public ResetChanceComponent(LiveSplitState state)
    {
        Settings = new ResetChanceSettings();
        InternalComponent = new InfoTextComponent("Reset Chance", "0%");

        state.OnStart += state_OnStart;
        state.OnSplit += state_OnSplitChange;
        state.OnSkipSplit += state_OnSplitChange;
        state.OnUndoSplit += state_OnSplitChange;
        state.OnReset += state_OnReset;

        CurrentState = state;

        ResetChancesValid = false;
        CurrentSplitValid = false;
    }

    List<float> CalculateResetChances(LiveSplitState state)
    {
        List<float> chances = new List<float>();

        for (int i = 0; i < state.Run.Count(); i++)
        {
            ISegment currentSegment = state.Run[i];

            float numCompletions = currentSegment.SegmentHistory.Count;

            float numAttempts = i == 0 ? state.Run.AttemptHistory.Count : state.Run[i-1].SegmentHistory.Count;

            float resetChance = -1;

            if (numCompletions > 0 && numAttempts > 0)
            {
                resetChance = (float)((1 - (numCompletions / numAttempts)) * 100);
            }

            chances.Add(resetChance);
        }

        return chances;
    }

    float GetResetChance(LiveSplitState state)
    {
        bool noResetChance = state.CurrentPhase.Equals(TimerPhase.NotRunning) || state.CurrentPhase.Equals(TimerPhase.Ended);
        return noResetChance ? 0 : ResetChances[state.CurrentSplitIndex];
    }

    void state_OnStart(object sender, EventArgs e)
    {
        ResetChancesValid = false;
        CurrentSplitValid = false;
    }

    void state_OnSplitChange(object sender, EventArgs e)
    {
        CurrentSplitValid = false;
    }

    void state_OnReset(object sender, TimerPhase e)
    {
        CurrentSplitValid = false;
    }

    public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
    {
        InternalComponent.NameLabel.HasShadow
            = InternalComponent.ValueLabel.HasShadow
            = state.LayoutSettings.DropShadows;

        InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
        InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

        InternalComponent.DrawHorizontal(g, state, height, clipRegion);
    }

    // We will be adding the ability to display the component across two rows in our settings menu.
    public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
    {
        InternalComponent.DisplayTwoRows = Settings.Display2Rows;

        InternalComponent.NameLabel.HasShadow
            = InternalComponent.ValueLabel.HasShadow
            = state.LayoutSettings.DropShadows;

        InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
        InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

        InternalComponent.DrawVertical(g, state, width, clipRegion);
    }

    public Control GetSettingsControl(LayoutMode mode)
    {
        Settings.Mode = mode;
        return Settings;
    }

    public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
    {
        return Settings.GetSettings(document);
    }

    public void SetSettings(System.Xml.XmlNode settings)
    {
        Settings.SetSettings(settings);
    }

    // This is the function where we decide what needs to be displayed at this moment in time,
    // and tell the internal component to display it. This function is called hundreds to
    // thousands of times per second.
    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
    {
        if (!ResetChancesValid)
        {
            ResetChances = CalculateResetChances(state);
        }

        if (!CurrentSplitValid)
        {
            CurrentResetChance = GetResetChance(state);


            // Format with no decimal points.
            string resetChanceFormat = $"{CurrentResetChance:0}%";
            if (Settings.Accuracy.Equals(ResetChanceSettings.ResetChanceAccuracy.OneDecimal))
            {
                // Format with up to one decimal point.
                resetChanceFormat = $"{CurrentResetChance:0.#}%";
            }
            else if (Settings.Accuracy.Equals(ResetChanceSettings.ResetChanceAccuracy.TwoDecimal))
            {
                // Format with up to two decimal points.
                resetChanceFormat = $"{CurrentResetChance:0.##}%";
            }
            // If we can't make an estimate, just display "?".
            InternalComponent.InformationValue = CurrentResetChance >= 0 ? resetChanceFormat : "?";
        }

        InternalComponent.Update(invalidator, state, width, height, mode);
    }

    // This function is called when the component is removed from the layout, or when LiveSplit
    // closes a layout with this component in it.
    public void Dispose()
    {
        CurrentState.OnStart -= state_OnStart;
        CurrentState.OnSplit -= state_OnSplitChange;
        CurrentState.OnSkipSplit -= state_OnSplitChange;
        CurrentState.OnUndoSplit -= state_OnSplitChange;
        CurrentState.OnReset -= state_OnReset;
    }

    // I do not know what this is for.
    public int GetSettingsHashCode() => Settings.GetSettingsHashCode();
}