using System;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using LiveSplit.TimeFormatters;

namespace LiveSplit.UI.Components
{
    public partial class ImOutSettings : UserControl
    {
        public new float Height { get; set; }
        public new float Width { get; set; }

        public bool DropDecimal { get; set; }
        public TimeAccuracy DeltaAccuracy { get; set; }
        public string Comparison {  get; set; }

        public LiveSplitState CurrentState { get; set; }

        public ImOutSettings()
        {
            InitializeComponent();

            Height = 200;
            Width = 200;

            DropDecimal = true;
            DeltaAccuracy = TimeAccuracy.Tenths;
            Comparison = "Current Comparison";

            cbDropDecimal.Enabled = true;

            cbDropDecimal.DataBindings.Clear();
            cbDropDecimal.DataBindings.Add("Checked", this, "DropDecimal", false, DataSourceUpdateMode.OnPropertyChanged);

            cmbComparison.DataBindings.Clear();
            cmbComparison.DataBindings.Add("SelectedItem", this, "Comparison", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                SettingsHelper.CreateSetting(document, parent, "DropDecimal", DropDecimal) ^
                SettingsHelper.CreateSetting(document, parent, "DeltaAccuracy", DeltaAccuracy) ^
                SettingsHelper.CreateSetting(document, parent, "Comparison", Comparison);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            DropDecimal = SettingsHelper.ParseBool(element["DropDecimal"]);
            DeltaAccuracy = SettingsHelper.ParseEnum<TimeAccuracy>(element["DeltaAccuracy"]);
            Comparison = SettingsHelper.ParseString(element["Comparison"]);
        }

        private void ImOutSettings_Load(object sender, EventArgs e)
        {
            cmbComparison.Items.Clear();
            cmbComparison.Items.Add("Current Comparison");
            cmbComparison.Items.AddRange(CurrentState.Run.Comparisons.Where(x => x != BestSplitTimesComparisonGenerator.ComparisonName && x != NoneComparisonGenerator.ComparisonName).ToArray());
            if (!cmbComparison.Items.Contains(Comparison))
            {
                cmbComparison.Items.Add(Comparison);
            }

            rdoMilliseconds.Checked = DeltaAccuracy == TimeAccuracy.Milliseconds;
            rdoHundredths.Checked = DeltaAccuracy == TimeAccuracy.Hundredths;
            rdoTenths.Checked = DeltaAccuracy == TimeAccuracy.Tenths;
            rdoSeconds.Checked = DeltaAccuracy == TimeAccuracy.Seconds;
        }

        private void UpdateAccuracy()
        {
            DeltaAccuracy = rdoSeconds.Checked ? TimeAccuracy.Seconds : 
                rdoTenths.Checked ? TimeAccuracy.Tenths :
                rdoHundredths.Checked ? TimeAccuracy.Hundredths :
                TimeAccuracy.Milliseconds;
        }

        private void rdoSeconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoTenths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoHundredths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }

        private void rdoMilliseconds_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAccuracy();
        }
    }

}
