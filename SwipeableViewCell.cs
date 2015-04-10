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

			var view = new UIView (CGRect.Empty);

			SetSwipeGestureWithView (
				view,
				UIColor.Green,
				SwipeTableCellMode.Exit,
				SwipeTableViewCellState.StateRightShort,
				(_cell, state, mode) => {}
			);

			SetSwipeGestureWithView (
				view,
				UIColor.Red,
				SwipeTableCellMode.Exit,
				SwipeTableViewCellState.StateLeftShort,
				(_cell, state, mode) => {}
			);
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

