using System.Windows.Forms;

namespace DiagServerAccessor
{
    interface IControlGroup
    {
        Panel CreateLayout();
    }

    class MotorOutputGroup : IControlGroup
    {
        public enum eNeutralMode
        {
            Coast = 0,
            Brake = 1
        }

        public eNeutralMode NeutralMode;

        public Panel CreateLayout()
        {
            Label label = new Label();
            label.Text = "NeutralMode";
            label.Dock = DockStyle.Fill;

            ComboBox combo = new ComboBox();
            combo.Dock = DockStyle.Fill;
            combo.Items.Add(eNeutralMode.Coast);
            combo.Items.Add(eNeutralMode.Brake);
            combo.SelectedItem = NeutralMode;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            TableLayoutPanel grid = new TableLayoutPanel();
            grid.RowCount = 1;
            grid.ColumnCount = 2;
            grid.Dock = DockStyle.Fill;
            grid.Controls.Add(label);
            grid.Controls.Add(combo);

            Panel ret = new Panel();
            ret.Dock = DockStyle.Fill;
            ret.Controls.Add(grid);
            return ret;
        }
    }

    class HardLimitSwitchGroup : IControlGroup
    {
        public enum eModeOfOperation
        {
            Disabled = 0,
            NormallyOpen = 1,
            NormallyClosed = 2
        }

        public eModeOfOperation LimitSwitchForward;
        public eModeOfOperation LimitSwitchReverse;

        public Panel CreateLayout()
        {
            Label forwardLabel = new Label();
            forwardLabel.Text = "Limit Switch Forward";
            forwardLabel.Dock = DockStyle.Fill;

            Label reverseLabel = new Label();
            reverseLabel.Text = "Limit Switch Reverse";
            reverseLabel.Dock = DockStyle.Fill;

            ComboBox forwardCombo = new ComboBox();
            forwardCombo.Dock = DockStyle.Fill;
            forwardCombo.Items.Add(eModeOfOperation.Disabled);
            forwardCombo.Items.Add(eModeOfOperation.NormallyOpen);
            forwardCombo.Items.Add(eModeOfOperation.NormallyClosed);
            forwardCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            forwardCombo.SelectedItem = LimitSwitchForward;

            ComboBox reverseCombo = new ComboBox();
            reverseCombo.Dock = DockStyle.Fill;
            reverseCombo.Items.Add(eModeOfOperation.Disabled);
            reverseCombo.Items.Add(eModeOfOperation.NormallyOpen);
            reverseCombo.Items.Add(eModeOfOperation.NormallyClosed);
            reverseCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            reverseCombo.SelectedItem = LimitSwitchReverse;

            TableLayoutPanel grid = new TableLayoutPanel();
            grid.RowCount = 2;
            grid.ColumnCount = 2;
            grid.Dock = DockStyle.Fill;
            grid.Controls.Add(forwardLabel);
            grid.Controls.Add(forwardCombo);
            grid.Controls.Add(reverseLabel);
            grid.Controls.Add(reverseCombo);

            Panel ret = new Panel();
            ret.Dock = DockStyle.Fill;
            ret.Controls.Add(grid);
            return ret;
        }
    }

    class SoftLimitSwitchGroup : IControlGroup
    {
        public bool ForwardSoftLimitEnable;
        public bool ReverseSoftLimitEnable;
        public int SoftLimitForwardValue;
        public int SoftLimitReverseValue;


        public Panel CreateLayout()
        {
            Label forwardEnableLabel = new Label();
            forwardEnableLabel.Text = "Forward Soft Limit Switch Enable";
            forwardEnableLabel.Dock = DockStyle.Fill;

            Label reverseEnableLabel = new Label();
            reverseEnableLabel.Text = "Reverse Soft Limit Switch Enable";
            reverseEnableLabel.Dock = DockStyle.Fill;

            Label forwardValueLabel = new Label();
            forwardValueLabel.Text = "Forward Soft Limit Switch Value";
            forwardValueLabel.Dock = DockStyle.Fill;

            Label reverseValueLabel = new Label();
            reverseValueLabel.Text = "Reverse Soft Limit Switch Value";
            reverseValueLabel.Dock = DockStyle.Fill;

            CheckBox forwardEnable = new CheckBox();
            forwardEnable.Dock = DockStyle.Fill;
            forwardEnable.Checked = ForwardSoftLimitEnable;

            CheckBox reverseEnable = new CheckBox();
            reverseEnable.Dock = DockStyle.Fill;
            reverseEnable.Checked = ReverseSoftLimitEnable;

            NumericUpDown forwardValue = new NumericUpDown();
            forwardValue.Minimum = decimal.MinValue;
            forwardValue.Maximum = decimal.MaxValue;
            forwardValue.Dock = DockStyle.Fill;
            forwardValue.Value = SoftLimitForwardValue;

            NumericUpDown reverseValue = new NumericUpDown();
            reverseValue.Minimum = decimal.MinValue;
            reverseValue.Maximum = decimal.MaxValue;
            reverseValue.Dock = DockStyle.Fill;
            reverseValue.Value = SoftLimitReverseValue;

            TableLayoutPanel grid = new TableLayoutPanel();
            grid.RowCount = 4;
            grid.ColumnCount = 2;
            grid.Dock = DockStyle.Fill;
            grid.Controls.Add(forwardEnableLabel);
            grid.Controls.Add(forwardEnable);
            grid.Controls.Add(reverseEnableLabel);
            grid.Controls.Add(reverseEnable);
            grid.Controls.Add(forwardValueLabel);
            grid.Controls.Add(forwardValue);
            grid.Controls.Add(reverseValueLabel);
            grid.Controls.Add(reverseValue);

            Panel ret = new Panel();
            ret.Dock = DockStyle.Fill;
            ret.Controls.Add(grid);
            return ret;
        }

    }

    class SlotGroup : IControlGroup
    {
        public float pGain;
        public float iGain;
        public float dGain;
        public float fGain;
        public float iZone;
        public float clRampRate;

        public Panel CreateLayout()
        {
            Label pLabel = new Label();
            pLabel.Text = "P Gain";
            pLabel.Dock = DockStyle.Fill;

            Label ilabel = new Label();
            ilabel.Text = "I Gain";
            ilabel.Dock = DockStyle.Fill;

            Label dLabel = new Label();
            dLabel.Text = "D Gain";
            dLabel.Dock = DockStyle.Fill;

            Label fLabel = new Label();
            fLabel.Text = "F Gain";
            fLabel.Dock = DockStyle.Fill;

            Label iZoneLabel = new Label();
            iZoneLabel.Text = "I Zone";
            iZoneLabel.Dock = DockStyle.Fill;

            Label clRampLabel = new Label();
            clRampLabel.Text = "Closed Loop Ramp Rate";
            clRampLabel.Dock = DockStyle.Fill;

            NumericUpDown p = new NumericUpDown();
            p.Minimum = decimal.MinValue;
            p.Maximum = decimal.MaxValue;
            p.Dock = DockStyle.Fill;
            p.Value = (decimal)pGain;

            NumericUpDown i = new NumericUpDown();
            i.Minimum = decimal.MinValue;
            i.Maximum = decimal.MaxValue;
            i.Dock = DockStyle.Fill;
            i.Value = (decimal)iGain;

            NumericUpDown d = new NumericUpDown();
            d.Minimum = decimal.MinValue;
            d.Maximum = decimal.MaxValue;
            d.Dock = DockStyle.Fill;
            d.Value = (decimal)dGain;

            NumericUpDown f = new NumericUpDown();
            f.Minimum = decimal.MinValue;
            f.Maximum = decimal.MaxValue;
            f.Dock = DockStyle.Fill;
            f.Value = (decimal)fGain;

            NumericUpDown iZ = new NumericUpDown();
            iZ.Minimum = decimal.MinValue;
            iZ.Maximum = decimal.MaxValue;
            iZ.Dock = DockStyle.Fill;
            iZ.Value = (decimal)iZone;

            NumericUpDown clRamp = new NumericUpDown();
            clRamp.Minimum = decimal.MinValue;
            clRamp.Maximum = decimal.MaxValue;
            clRamp.Dock = DockStyle.Fill;
            clRamp.Value = (decimal)clRampRate;


            TableLayoutPanel grid = new TableLayoutPanel();
            grid.RowCount = 6;
            grid.ColumnCount = 2;
            grid.Dock = DockStyle.Fill;
            grid.Controls.Add(pLabel);
            grid.Controls.Add(p);
            grid.Controls.Add(ilabel);
            grid.Controls.Add(i);
            grid.Controls.Add(dLabel);
            grid.Controls.Add(d);
            grid.Controls.Add(fLabel);
            grid.Controls.Add(f);
            grid.Controls.Add(iZoneLabel);
            grid.Controls.Add(iZ);
            grid.Controls.Add(clRampLabel);
            grid.Controls.Add(clRamp);

            Panel ret = new Panel();
            ret.Dock = DockStyle.Fill;
            ret.Controls.Add(grid);
            return ret;
        }
    }

}
