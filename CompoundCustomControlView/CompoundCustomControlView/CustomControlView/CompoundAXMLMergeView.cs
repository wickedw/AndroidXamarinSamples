using Android.Content;
using Android.Util;
using Android.Widget;
using Android.Views;

namespace CompoundCustomControlView
{
	public class CompoundAXMLMergeView: LinearLayout
	{
		public CompoundAXMLMergeView (Context context) :
			base (context)
		{
			Initialize ();
		}

		public CompoundAXMLMergeView (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public CompoundAXMLMergeView (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			// We need to add this as we are not using the nested layout in this instance
			this.Orientation = Orientation.Vertical;

			SetBackgroundColor (new Android.Graphics.Color (255, 0, 0 ));

			Inflate (Context, Resource.Layout.CompoundAXMLMergeViewLayout, this);

			TextView tv = new TextView (Context);
			tv.Text = "Text3.1";

			Button b = new Button (Context);
			b.Text = "Button3.1";

			AddView (tv);
			AddView (b);
		}
	}
}

