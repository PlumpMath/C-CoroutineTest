using System.Windows.Forms;

namespace SafeCoroutine
{
    public class WaitForButtonClick : IYieldInstruction
    {
        private Button mButton;
        private bool mIsClicked = false;

        public WaitForButtonClick(Button btn)
        {
            mButton = btn;
            mButton.Click += (sender, e) => { mIsClicked = true; };
        }

        public bool IsComplete(float delta_time)
        {
            return mIsClicked;
        }
    }
}
