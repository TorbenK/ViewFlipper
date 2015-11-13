# ViewFlipper
Flips two Views around X or Y axis

![](https://j.gifs.com/yoBOrA.gif)

## Usage

No nuget package available. Will add based on interest.

#### Add XAML namespace:

```
xmlns:flipper="clr-namespace:ViewFlipper.FormsPlugin.Abstractions;assembly=ViewFlipper.FormsPlugin.Abstractions"
```

#### Create ViewFlipper
```XAML
<flipper:ViewFlipper
  BackgroundColor="White">
  <flipper:ViewFlipper.FrontView>
    <Label
      XAlign="Center"
      YAlign="Center"
      Text="Tap to show image" />
  </flipper:ViewFlipper.FrontView>
  <flipper:ViewFlipper.BackView>
    <Image 
      Source="icon.png" 
      Aspect="Fill" />
  </flipper:ViewFlipper.BackView>
</flipper:ViewFlipper>
```

#### I recommend taking a look at the sample

## Available properties

```C#
/// <summary>
/// Gets/Sets the front view
/// </summary>
public View FrontView
{
    get { return (View)this.GetValue(FrontViewProperty); }
    set { this.SetValue(FrontViewProperty, value); }
}
/// <summary>
/// Gets/Sets the back view
/// </summary>
public View BackView
{
    get { return (View)this.GetValue(BackViewProperty); }
    set { this.SetValue(BackViewProperty, value); }
}
/// <summary>
/// Gets/Sets if a flip will be perfomed when tapping anywhere inside the <c>ViewFlipper</c>
/// </summary>
public bool FlipOnTap
{
    get { return (bool)this.GetValue(FlipOnTapProperty); }
    set { this.SetValue(FlipOnTapProperty, value); }
}
/// <summary>
/// Gets/Sets the current state of the <c>ViewFlipper</c>. This toggles the animation when changed
/// </summary>
public FlipState FlipState
{
    get { return (FlipState)this.GetValue(FlipStateProperty); }
    set { this.SetValue(FlipStateProperty, value); }
}
/// <summary>
/// Gets/Sets the duration of the flip animation
/// </summary>
public int AnimationDuration
{
    get { return (int)this.GetValue(AnimationDurationProperty); }
    set { this.SetValue(AnimationDurationProperty, value); }
}
/// <summary>
/// Gets/Sets if the flip will be in horizontal or vertical direction
/// </summary>
public RotationDirection RotationDirection
{
    get { return (RotationDirection)this.GetValue(RotationDirectionProperty); }
    set { this.SetValue(RotationDirectionProperty, value); }
}
```

## License

```
The MIT License (MIT)

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
