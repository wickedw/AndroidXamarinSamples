using Android.Content;
using Android.Util;
using Android.Widget;

namespace CompoundCustomControlView
{
	public class CompoundCodeView : LinearLayout
	{
		public CompoundCodeView (Context context) :
			base (context)
		{
			Initialize ();
		}

		public CompoundCodeView (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public CompoundCodeView (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			// Add custom controls to your view with some code
			TextView tv = new TextView (Context);
			tv.Text = "Text1";

			Button b = new Button (Context);
			b.Text = "Button1";

			AddView (tv);
			AddView (b);
		}
	}
}

