using LiveSplit.UI.Components;
using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class ImOutComponent : ControlComponent
    {
        protected ImOutControl InternalComponent { get; set; }
        public ImOutSettings Settings { get; set; }
        protected LiveSplitState State { get; set; }

        public override string ComponentName => "I'm Out!";

        public override float HorizontalWidth => Settings.Width;

        public override float MinimumHeight => 10;

        public override float VerticalHeight => Settings.Height;

        public override float MinimumWidth => 10;

        public IDictionary<string, Action> ContextMenuControls => null;

        public ImOutComponent(LiveSplitState state) : this(state, CreateImageControl()) { }

        public ImOutComponent(LiveSplitState state, Control image) : base(state, image, ex => ErrorCallback(state.Form, ex)) 
        {
            State = state;
            Settings = new ImOutSettings();
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

            control.Image = Image.FromFile(@"C:\Users\Lewis\Downloads\im out.png");

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