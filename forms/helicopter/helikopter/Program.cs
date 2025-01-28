using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;


namespace helikopter
{
    class Program
    {
        DirectInput directInput;
        static void Main(string[] args)
        {

        }
        private void ConfigEditDialog_Load(object sender, EventArgs e)
        {
            directInput = new DirectInput();
            var list = directInput.GetDevices(DeviceClass.GameControl, DeviceEnumerationFlags.AttachedOnly);
            if (list.Count > 0)
            {
                inputDevice = new Joystick(directInput, list.First().InstanceGuid);
                tableLayoutPanel1.RowCount = actionNames.Length;
                for (int i = 0; i < actionNames.Length; i++)
                {
                    tableLayoutPanel1.Controls.Add(new Label()
                    {
                        AutoSize = true,
                        Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top,
                        Text = actionNames[i],
                        TextAlign = ContentAlignment.MiddleLeft
                    }, 0, i);
                    ButtonControl buttonControl = new ButtonControl() { Enabled = false };
                    tableLayoutPanel1.Controls.Add(buttonControl, 1, i);
                    buttonControls.Add(buttonControl);
                    buttonControl.SetButtonClicked += buttonControl_SetButtonClicked;
                    buttonControl.ClearButtonClicked += buttonControl_ClearButtonClicked;
                    if (i == tableLayoutPanel1.RowStyles.Count)
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                }
            }
            else
                tabControl1.TabPages.Remove(tabPage_Controller);
            // Load the config INI upon window load
            LoadConfigIni();
        }
    }
}
