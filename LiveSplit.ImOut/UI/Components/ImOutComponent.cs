using LiveSplit.UI.Components;
using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;
using LiveSplit.TimeFormatters;

namespace LiveSplit.UI.Components
{
    public class ImOutComponent : ControlComponent
    {
        protected ImOutControl InternalComponent { get; set; }
        public ImOutSettings Settings { get; set; }
        protected LiveSplitState State { get; set; }
        protected DeltaTimeFormatter TimeFormatter { get; set; }
        private ImOutGenerator ImageGen { get; set; }

        protected bool ControlStateValid { get; set; }

        public override string ComponentName => "I'm Out!";

        public override float HorizontalWidth => Settings.Width;

        public override float MinimumHeight => 10;

        public override float VerticalHeight => Settings.Height;

        public override float MinimumWidth => 10;

        public IDictionary<string, Action> ContextMenuControls => null;

        public ImOutComponent(LiveSplitState state) : this(state, CreateImageControl()) { }

        public ImOutComponent(LiveSplitState state, ImOutControl image) : base(state, image, ex => ErrorCallback(state.Form, ex)) 
        {
            InternalComponent = image;
            State = state;
            Settings = new ImOutSettings()
            {
                CurrentState = state
            };
            TimeFormatter = new DeltaTimeFormatter();
            ImageGen = new ImOutGenerator();
            ControlStateValid = false;

            state.OnStart += state_OnStart;
            state.OnSplit += state_OnSplitChange;
            state.OnUndoSplit += state_OnSplitChange;
            state.OnSkipSplit += state_OnSplitChange;
            state.OnReset += state_OnReset;
        }

        private void state_OnStart(object sender, EventArgs e)
        {

            
            ControlStateValid = false;
        }

        private void state_OnSplitChange(object sender, EventArgs e)
        {
            ControlStateValid = false;
        }

        private void state_OnReset(object sender, TimerPhase e)
        {
            ControlStateValid = false;
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!ControlStateValid)
            {
                var currentSplitIndex = state.CurrentSplitIndex;
                TimingMethod timingMethod = state.CurrentTimingMethod;
                var comparison = state.CurrentComparison;
                if (currentSplitIndex > 0)
                {
                    var prevSplit = state.Run[currentSplitIndex - 1];
                    TimeSpan? deltaTime = prevSplit.SplitTime[timingMethod] - prevSplit.Comparisons[comparison][timingMethod];

                    if (deltaTime.HasValue)
                    {
                        ImageGen.DrawImage(TimeFormatter.Format(deltaTime));
                        var seconds = deltaTime.Value.TotalSeconds;

                        InternalComponent.SetControl(ImOutControl.ImageState.Running);
                    }
                    else
                    {
                        InternalComponent.SetControl(ImOutControl.ImageState.Unknown);
                    }
                }
                else
                {
                    InternalComponent.SetControl(ImOutControl.ImageState.Unknown);
                }

                ControlStateValid = true;
            }

            InternalComponent.PrintDebug();
        }

        private static void ErrorCallback(Form form, Exception ex)
        {
            MessageBox.Show("Error");
        }


        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public int GetSettingsHashCode()
        {
            return Settings.GetSettingsHashCode();
        }

        private void DisposeIfError()
        {
            if (ErrorWithControl && !InternalComponent.IsDisposed)
            {
                Dispose();
            }
        }

        private static ImOutControl CreateImageControl()
        {
            var control = new ImOutControl();

            return control;
        }

        public override void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            base.DrawVertical(g, state, width, clipRegion);
            DisposeIfError();
        }

        public override void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            base.DrawHorizontal(g, state, height, clipRegion);
            DisposeIfError();
        }
    }
}