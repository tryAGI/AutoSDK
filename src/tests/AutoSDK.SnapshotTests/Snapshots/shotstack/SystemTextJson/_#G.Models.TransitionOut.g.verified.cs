//HintName: G.Models.TransitionOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transition out. Available transitions are:<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`fade` - fade out&lt;/li&gt;<br/>
    ///     &lt;li&gt;`reveal` - reveal from right to left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideLeft` - move slightly left and fade out&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideRight` - move slightly right and fade out&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideUp` - move slightly up and fade out&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideDown` - move slightly down and fade out&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselLeft` - slide out from right to left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselRight` - slide out from left to right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselUp` - slide out from bottom to top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselDown` - slide out from top  to bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleTopRight` - rotate out from top right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleRightTop` - rotate out from right top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleRightBottom` - rotate out from right bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleBottomRight` - rotate out from bottom right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleBottomLeft` - rotate out from bottom left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleLeftBottom` - rotate out from left bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleLeftTop` - rotate out from left top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleTopLeft` - rotate out from top left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`zoom` - fast zoom out&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
    /// </summary>
    public enum TransitionOut
    {
        /// <summary>
        /// 
        /// </summary>
        CarouselDown,
        /// <summary>
        /// 
        /// </summary>
        CarouselDownFast,
        /// <summary>
        /// 
        /// </summary>
        CarouselDownSlow,
        /// <summary>
        /// 
        /// </summary>
        CarouselLeft,
        /// <summary>
        /// 
        /// </summary>
        CarouselLeftFast,
        /// <summary>
        /// 
        /// </summary>
        CarouselLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        CarouselRight,
        /// <summary>
        /// 
        /// </summary>
        CarouselRightFast,
        /// <summary>
        /// 
        /// </summary>
        CarouselRightSlow,
        /// <summary>
        /// 
        /// </summary>
        CarouselUp,
        /// <summary>
        /// 
        /// </summary>
        CarouselUpFast,
        /// <summary>
        /// 
        /// </summary>
        CarouselUpSlow,
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        FadeFast,
        /// <summary>
        /// 
        /// </summary>
        FadeSlow,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Reveal,
        /// <summary>
        /// 
        /// </summary>
        RevealFast,
        /// <summary>
        /// 
        /// </summary>
        RevealSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomLeft,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomLeftFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomRight,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomRightFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleBottomRightSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftBottom,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftBottomFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftBottomSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftTop,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftTopFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleLeftTopSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightBottom,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightBottomFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightBottomSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightTop,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightTopFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleRightTopSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopLeft,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopLeftFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopRight,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopRightFast,
        /// <summary>
        /// 
        /// </summary>
        ShuffleTopRightSlow,
        /// <summary>
        /// 
        /// </summary>
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        SlideDownFast,
        /// <summary>
        /// 
        /// </summary>
        SlideDownSlow,
        /// <summary>
        /// 
        /// </summary>
        SlideLeft,
        /// <summary>
        /// 
        /// </summary>
        SlideLeftFast,
        /// <summary>
        /// 
        /// </summary>
        SlideLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        SlideRight,
        /// <summary>
        /// 
        /// </summary>
        SlideRightFast,
        /// <summary>
        /// 
        /// </summary>
        SlideRightSlow,
        /// <summary>
        /// 
        /// </summary>
        SlideUp,
        /// <summary>
        /// 
        /// </summary>
        SlideUpFast,
        /// <summary>
        /// 
        /// </summary>
        SlideUpSlow,
        /// <summary>
        /// 
        /// </summary>
        WipeLeft,
        /// <summary>
        /// 
        /// </summary>
        WipeLeftFast,
        /// <summary>
        /// 
        /// </summary>
        WipeLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        WipeRight,
        /// <summary>
        /// 
        /// </summary>
        WipeRightFast,
        /// <summary>
        /// 
        /// </summary>
        WipeRightSlow,
        /// <summary>
        /// 
        /// </summary>
        Zoom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransitionOutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransitionOut value)
        {
            return value switch
            {
                TransitionOut.CarouselDown => "carouselDown",
                TransitionOut.CarouselDownFast => "carouselDownFast",
                TransitionOut.CarouselDownSlow => "carouselDownSlow",
                TransitionOut.CarouselLeft => "carouselLeft",
                TransitionOut.CarouselLeftFast => "carouselLeftFast",
                TransitionOut.CarouselLeftSlow => "carouselLeftSlow",
                TransitionOut.CarouselRight => "carouselRight",
                TransitionOut.CarouselRightFast => "carouselRightFast",
                TransitionOut.CarouselRightSlow => "carouselRightSlow",
                TransitionOut.CarouselUp => "carouselUp",
                TransitionOut.CarouselUpFast => "carouselUpFast",
                TransitionOut.CarouselUpSlow => "carouselUpSlow",
                TransitionOut.Fade => "fade",
                TransitionOut.FadeFast => "fadeFast",
                TransitionOut.FadeSlow => "fadeSlow",
                TransitionOut.None => "none",
                TransitionOut.Reveal => "reveal",
                TransitionOut.RevealFast => "revealFast",
                TransitionOut.RevealSlow => "revealSlow",
                TransitionOut.ShuffleBottomLeft => "shuffleBottomLeft",
                TransitionOut.ShuffleBottomLeftFast => "shuffleBottomLeftFast",
                TransitionOut.ShuffleBottomLeftSlow => "shuffleBottomLeftSlow",
                TransitionOut.ShuffleBottomRight => "shuffleBottomRight",
                TransitionOut.ShuffleBottomRightFast => "shuffleBottomRightFast",
                TransitionOut.ShuffleBottomRightSlow => "shuffleBottomRightSlow",
                TransitionOut.ShuffleLeftBottom => "shuffleLeftBottom",
                TransitionOut.ShuffleLeftBottomFast => "shuffleLeftBottomFast",
                TransitionOut.ShuffleLeftBottomSlow => "shuffleLeftBottomSlow",
                TransitionOut.ShuffleLeftTop => "shuffleLeftTop",
                TransitionOut.ShuffleLeftTopFast => "shuffleLeftTopFast",
                TransitionOut.ShuffleLeftTopSlow => "shuffleLeftTopSlow",
                TransitionOut.ShuffleRightBottom => "shuffleRightBottom",
                TransitionOut.ShuffleRightBottomFast => "shuffleRightBottomFast",
                TransitionOut.ShuffleRightBottomSlow => "shuffleRightBottomSlow",
                TransitionOut.ShuffleRightTop => "shuffleRightTop",
                TransitionOut.ShuffleRightTopFast => "shuffleRightTopFast",
                TransitionOut.ShuffleRightTopSlow => "shuffleRightTopSlow",
                TransitionOut.ShuffleTopLeft => "shuffleTopLeft",
                TransitionOut.ShuffleTopLeftFast => "shuffleTopLeftFast",
                TransitionOut.ShuffleTopLeftSlow => "shuffleTopLeftSlow",
                TransitionOut.ShuffleTopRight => "shuffleTopRight",
                TransitionOut.ShuffleTopRightFast => "shuffleTopRightFast",
                TransitionOut.ShuffleTopRightSlow => "shuffleTopRightSlow",
                TransitionOut.SlideDown => "slideDown",
                TransitionOut.SlideDownFast => "slideDownFast",
                TransitionOut.SlideDownSlow => "slideDownSlow",
                TransitionOut.SlideLeft => "slideLeft",
                TransitionOut.SlideLeftFast => "slideLeftFast",
                TransitionOut.SlideLeftSlow => "slideLeftSlow",
                TransitionOut.SlideRight => "slideRight",
                TransitionOut.SlideRightFast => "slideRightFast",
                TransitionOut.SlideRightSlow => "slideRightSlow",
                TransitionOut.SlideUp => "slideUp",
                TransitionOut.SlideUpFast => "slideUpFast",
                TransitionOut.SlideUpSlow => "slideUpSlow",
                TransitionOut.WipeLeft => "wipeLeft",
                TransitionOut.WipeLeftFast => "wipeLeftFast",
                TransitionOut.WipeLeftSlow => "wipeLeftSlow",
                TransitionOut.WipeRight => "wipeRight",
                TransitionOut.WipeRightFast => "wipeRightFast",
                TransitionOut.WipeRightSlow => "wipeRightSlow",
                TransitionOut.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransitionOut? ToEnum(string value)
        {
            return value switch
            {
                "carouselDown" => TransitionOut.CarouselDown,
                "carouselDownFast" => TransitionOut.CarouselDownFast,
                "carouselDownSlow" => TransitionOut.CarouselDownSlow,
                "carouselLeft" => TransitionOut.CarouselLeft,
                "carouselLeftFast" => TransitionOut.CarouselLeftFast,
                "carouselLeftSlow" => TransitionOut.CarouselLeftSlow,
                "carouselRight" => TransitionOut.CarouselRight,
                "carouselRightFast" => TransitionOut.CarouselRightFast,
                "carouselRightSlow" => TransitionOut.CarouselRightSlow,
                "carouselUp" => TransitionOut.CarouselUp,
                "carouselUpFast" => TransitionOut.CarouselUpFast,
                "carouselUpSlow" => TransitionOut.CarouselUpSlow,
                "fade" => TransitionOut.Fade,
                "fadeFast" => TransitionOut.FadeFast,
                "fadeSlow" => TransitionOut.FadeSlow,
                "none" => TransitionOut.None,
                "reveal" => TransitionOut.Reveal,
                "revealFast" => TransitionOut.RevealFast,
                "revealSlow" => TransitionOut.RevealSlow,
                "shuffleBottomLeft" => TransitionOut.ShuffleBottomLeft,
                "shuffleBottomLeftFast" => TransitionOut.ShuffleBottomLeftFast,
                "shuffleBottomLeftSlow" => TransitionOut.ShuffleBottomLeftSlow,
                "shuffleBottomRight" => TransitionOut.ShuffleBottomRight,
                "shuffleBottomRightFast" => TransitionOut.ShuffleBottomRightFast,
                "shuffleBottomRightSlow" => TransitionOut.ShuffleBottomRightSlow,
                "shuffleLeftBottom" => TransitionOut.ShuffleLeftBottom,
                "shuffleLeftBottomFast" => TransitionOut.ShuffleLeftBottomFast,
                "shuffleLeftBottomSlow" => TransitionOut.ShuffleLeftBottomSlow,
                "shuffleLeftTop" => TransitionOut.ShuffleLeftTop,
                "shuffleLeftTopFast" => TransitionOut.ShuffleLeftTopFast,
                "shuffleLeftTopSlow" => TransitionOut.ShuffleLeftTopSlow,
                "shuffleRightBottom" => TransitionOut.ShuffleRightBottom,
                "shuffleRightBottomFast" => TransitionOut.ShuffleRightBottomFast,
                "shuffleRightBottomSlow" => TransitionOut.ShuffleRightBottomSlow,
                "shuffleRightTop" => TransitionOut.ShuffleRightTop,
                "shuffleRightTopFast" => TransitionOut.ShuffleRightTopFast,
                "shuffleRightTopSlow" => TransitionOut.ShuffleRightTopSlow,
                "shuffleTopLeft" => TransitionOut.ShuffleTopLeft,
                "shuffleTopLeftFast" => TransitionOut.ShuffleTopLeftFast,
                "shuffleTopLeftSlow" => TransitionOut.ShuffleTopLeftSlow,
                "shuffleTopRight" => TransitionOut.ShuffleTopRight,
                "shuffleTopRightFast" => TransitionOut.ShuffleTopRightFast,
                "shuffleTopRightSlow" => TransitionOut.ShuffleTopRightSlow,
                "slideDown" => TransitionOut.SlideDown,
                "slideDownFast" => TransitionOut.SlideDownFast,
                "slideDownSlow" => TransitionOut.SlideDownSlow,
                "slideLeft" => TransitionOut.SlideLeft,
                "slideLeftFast" => TransitionOut.SlideLeftFast,
                "slideLeftSlow" => TransitionOut.SlideLeftSlow,
                "slideRight" => TransitionOut.SlideRight,
                "slideRightFast" => TransitionOut.SlideRightFast,
                "slideRightSlow" => TransitionOut.SlideRightSlow,
                "slideUp" => TransitionOut.SlideUp,
                "slideUpFast" => TransitionOut.SlideUpFast,
                "slideUpSlow" => TransitionOut.SlideUpSlow,
                "wipeLeft" => TransitionOut.WipeLeft,
                "wipeLeftFast" => TransitionOut.WipeLeftFast,
                "wipeLeftSlow" => TransitionOut.WipeLeftSlow,
                "wipeRight" => TransitionOut.WipeRight,
                "wipeRightFast" => TransitionOut.WipeRightFast,
                "wipeRightSlow" => TransitionOut.WipeRightSlow,
                "zoom" => TransitionOut.Zoom,
                _ => null,
            };
        }
    }
}