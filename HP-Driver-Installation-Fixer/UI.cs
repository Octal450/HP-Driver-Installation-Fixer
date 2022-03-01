using System.Windows.Forms;

// Josh Davidson's Custom UI

namespace UI
{
    public class CommandLink : Button
    {
        public CommandLink()
        {
            this.FlatStyle = FlatStyle.System;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParams = base.CreateParams;
                cParams.Style |= 0x0000000E;
                return cParams;
            }
        }
    }
}
