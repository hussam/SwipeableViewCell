using UIKit;
using Foundation;
using CoreGraphics;

namespace SwipeableViewCell
{
	public class SwipeableViewCell : UITableViewCell
	{
		CellSwipeGestureRecognizer gr;

		public CellSwipeGestureRecognizer CellSwipeGestureRecognizer {
			get { return gr; }
		}

		[Export("initWithStyle:reuseIdentifier:")]
		public SwipeableViewCell(UITableViewCellStyle style, string reuseIdentifier) : base(style, reuseIdentifier)
		{
			gr = new CellSwipeGestureRecognizer (this);
			AddGestureRecognizer (gr);
		}

		public override void PrepareForReuse ()
		{
			base.PrepareForReuse ();
			gr.PrepForReuse (this);
		}

		public void SetSwipeGestureWithView(UIView view, UIColor color, SwipeTableCellMode mode, SwipeTableViewCellState state, SwipeCompletionBlock completionBlock)
		{
			gr.setSwipeGestureWithView (view, color, mode, state, completionBlock);
		}
	}
}

