using Android.Content;
using Android.Util;
using Android.Widget;

namespace CompoundCustomControlView
{
	public class CompoundAXMLView : LinearLayout
	{
		public CompoundAXMLView (Context context) :
			base (context)
		{
			Initialize ();
		}

		public CompoundAXMLView (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize ();
		}

		public CompoundAXMLView (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			SetBackgroundColor (new Android.Graphics.Color (100, 100, 100));

			Inflate (Context, Resource.Layout.CompoundAXMLViewLayout, this);

			var b1 = FindViewById<Button> (Resource.Id.compoundaxmlview_button);
			var tv1 = FindViewById<TextView> (Resource.Id.compoundaxmlview_textview);

			tv1.Text = "Text2";
			b1.Text = "Button2";

			// IMPORTANT: When we inflate, we add a nested LinearLayout inside our class level LinearLayout
			// and therefore if we want to add anything inside it our LinearLayout we must reference it explicitly as follows
			// Adding to the View via this.AddView will cause some confusion as our LinearLayout uses fill_parent and will take up the entire view
			// making it appear our other controls do not exist!
			var layout = FindViewById<LinearLayout> (Resource.Id.compoundaxmlview_outerlayout);

			TextView tv = new TextView (Context);
			tv.Text = "Text2.1";
			Button b = new Button (Context);
			b.Text = "Button2.1";

			// Add inside our layout
			layout.AddView (tv);
			layout.AddView (b);

			// This can be solved as required with merge (see CompoundAXMLMergeView)
		}
	}
}

