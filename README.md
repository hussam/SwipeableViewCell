SwipeableViewCell
--------------------

<p align="center"><img src="https://raw.github.com/hussamal/SwipeableViewCell/master/github-assets/mcswipe-front.png"/></p>

This is a .NET implementation of [MCSwipeTableViewCell](https://github.com/alikaragoz/MCSwipeTableViewCell) for Xamarin.iOS.

MCSwipeTableViewCell is:

>An Effort to show how one would implement a TableViewCell like the one we can see in the very well executed [Mailbox](http://www.mailboxapp.com/) iOS app. 

##Demo
###Exit Mode
The exit mode `SwipeTableCellMode.Exit` is the original behavior we can see in the Mailbox app. Swiping the cell should make it disappear. Convenient in destructive modes.

<p align="center"><img src="https://raw.github.com/hussamal/SwipeableViewCell/master/github-assets/mcswipe-exit.gif"/></p>

###Switch Mode
The switch mode `SwipeTableCellMode.Switch` is a new behavior that MCSwipeTableViewCell introduced. The cell will bounce back after selecting a state, this allows you to keep the cell. Convenient to switch an option quickly.

<p align="center"><img src="https://raw.github.com/hussamal/SwipeableViewCell/master/github-assets/mcswipe-switch.gif"/></p>

## API Reference
I've separated the behavior into a [SwipeGestureRecognizer](CellSwipeGestureRecognizer.cs) and [SwipeableViewCell](SwipeableViewCell.cs) that uses it. You can use ViewCell or the Gesture Recognizer directly if you want.

##Usage

```csharp
public class MyCell : SwipeableViewCell
{
   [Export("initWithStyle:reuseIdentifier")]
   public MyCell(UITableViewCellStyle style, string reuseIdentifier) : base(style, reuseIdentifier)
   {
      var checkView = new UIImageView (UIImage.FromBundle ("check"));
      checkView.ContentMode = UIViewContentMode.Center;

      var crossView = new UIImageView (UIImage.FromBundle ("cross"));
      crossView.ContentMode = UIViewContentMode.Center;

      SetSwipeGestureWithView (
            checkView,
            UIColor.Green,
            SwipeTableCellMode.Exit,
            SwipeTableViewCellState.StateRightShort,
            (_cell, state, mode) => {
               // do something
            }
         );

      SetSwipeGestureWithView (
            crossView,
            UIColor.Red,
            SwipeTableCellMode.Exit,
            SwipeTableViewCellState.StateLeftShort,
            (_cell, state, mode) => {
               // do something
            }
         );
   }
}
```


##Requirements
- iOS >= 7.0

## Contact

Hussam Abu-Libdeh

- http://github.com/hussam
- http://twitter.com/hussam

## Acknowledgement

Ali Karagoz

- http://github.com/alikaragoz
- http://twitter.com/alikaragoz

## License

SwipeableViewCell is available under the MIT license. See the LICENSE file for more info.
