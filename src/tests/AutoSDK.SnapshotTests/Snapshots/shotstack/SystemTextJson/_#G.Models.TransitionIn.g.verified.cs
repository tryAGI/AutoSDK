//HintName: G.Models.TransitionIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The transition in. Available transitions are:<br/>
    ///   &lt;ul&gt;<br/>
    ///     &lt;li&gt;`fade` - fade in&lt;/li&gt;<br/>
    ///     &lt;li&gt;`reveal` - reveal from left to right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`wipeLeft` - fade across screen to the left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`wipeRight` - fade across screen to the right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideLeft` - move slightly left and fade in&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideRight` - move slightly right and fade in&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideUp` - move slightly up and fade in&lt;/li&gt;<br/>
    ///     &lt;li&gt;`slideDown` - move slightly down and fade in&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselLeft` - slide in from right to left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselRight` - slide in from left to right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselUp` - slide in from bottom to top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`carouselDown` - slide in from top to bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleTopRight` - rotate in from top right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleRightTop` - rotate in from right top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleRightBottom` - rotate in from right bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleBottomRight` - rotate in from bottom right&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleBottomLeft` - rotate in from bottom left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleLeftBottom` - rotate in from left bottom&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleLeftTop` - rotate in from left top&lt;/li&gt;<br/>
    ///     &lt;li&gt;`shuffleTopLeft` - rotate in from top left&lt;/li&gt;<br/>
    ///     &lt;li&gt;`zoom` - fast zoom in&lt;/li&gt;<br/>
    ///   &lt;/ul&gt;<br/>
    /// The transition speed can also be controlled by appending `Fast` or `Slow` to the transition, e.g. `fadeFast` or `CarouselLeftSlow`.
    /// </summary>
    public enum TransitionIn
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
    public static class TransitionInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransitionIn value)
        {
            return value switch
            {
                TransitionIn.CarouselDown => "carouselDown",
                TransitionIn.CarouselDownFast => "carouselDownFast",
                TransitionIn.CarouselDownSlow => "carouselDownSlow",
                TransitionIn.CarouselLeft => "carouselLeft",
                TransitionIn.CarouselLeftFast => "carouselLeftFast",
                TransitionIn.CarouselLeftSlow => "carouselLeftSlow",
                TransitionIn.CarouselRight => "carouselRight",
                TransitionIn.CarouselRightFast => "carouselRightFast",
                TransitionIn.CarouselRightSlow => "carouselRightSlow",
                TransitionIn.CarouselUp => "carouselUp",
                TransitionIn.CarouselUpFast => "carouselUpFast",
                TransitionIn.CarouselUpSlow => "carouselUpSlow",
                TransitionIn.Fade => "fade",
                TransitionIn.FadeFast => "fadeFast",
                TransitionIn.FadeSlow => "fadeSlow",
                TransitionIn.None => "none",
                TransitionIn.Reveal => "reveal",
                TransitionIn.RevealFast => "revealFast",
                TransitionIn.RevealSlow => "revealSlow",
                TransitionIn.ShuffleBottomLeft => "shuffleBottomLeft",
                TransitionIn.ShuffleBottomLeftFast => "shuffleBottomLeftFast",
                TransitionIn.ShuffleBottomLeftSlow => "shuffleBottomLeftSlow",
                TransitionIn.ShuffleBottomRight => "shuffleBottomRight",
                TransitionIn.ShuffleBottomRightFast => "shuffleBottomRightFast",
                TransitionIn.ShuffleBottomRightSlow => "shuffleBottomRightSlow",
                TransitionIn.ShuffleLeftBottom => "shuffleLeftBottom",
                TransitionIn.ShuffleLeftBottomFast => "shuffleLeftBottomFast",
                TransitionIn.ShuffleLeftBottomSlow => "shuffleLeftBottomSlow",
                TransitionIn.ShuffleLeftTop => "shuffleLeftTop",
                TransitionIn.ShuffleLeftTopFast => "shuffleLeftTopFast",
                TransitionIn.ShuffleLeftTopSlow => "shuffleLeftTopSlow",
                TransitionIn.ShuffleRightBottom => "shuffleRightBottom",
                TransitionIn.ShuffleRightBottomFast => "shuffleRightBottomFast",
                TransitionIn.ShuffleRightBottomSlow => "shuffleRightBottomSlow",
                TransitionIn.ShuffleRightTop => "shuffleRightTop",
                TransitionIn.ShuffleRightTopFast => "shuffleRightTopFast",
                TransitionIn.ShuffleRightTopSlow => "shuffleRightTopSlow",
                TransitionIn.ShuffleTopLeft => "shuffleTopLeft",
                TransitionIn.ShuffleTopLeftFast => "shuffleTopLeftFast",
                TransitionIn.ShuffleTopLeftSlow => "shuffleTopLeftSlow",
                TransitionIn.ShuffleTopRight => "shuffleTopRight",
                TransitionIn.ShuffleTopRightFast => "shuffleTopRightFast",
                TransitionIn.ShuffleTopRightSlow => "shuffleTopRightSlow",
                TransitionIn.SlideDown => "slideDown",
                TransitionIn.SlideDownFast => "slideDownFast",
                TransitionIn.SlideDownSlow => "slideDownSlow",
                TransitionIn.SlideLeft => "slideLeft",
                TransitionIn.SlideLeftFast => "slideLeftFast",
                TransitionIn.SlideLeftSlow => "slideLeftSlow",
                TransitionIn.SlideRight => "slideRight",
                TransitionIn.SlideRightFast => "slideRightFast",
                TransitionIn.SlideRightSlow => "slideRightSlow",
                TransitionIn.SlideUp => "slideUp",
                TransitionIn.SlideUpFast => "slideUpFast",
                TransitionIn.SlideUpSlow => "slideUpSlow",
                TransitionIn.WipeLeft => "wipeLeft",
                TransitionIn.WipeLeftFast => "wipeLeftFast",
                TransitionIn.WipeLeftSlow => "wipeLeftSlow",
                TransitionIn.WipeRight => "wipeRight",
                TransitionIn.WipeRightFast => "wipeRightFast",
                TransitionIn.WipeRightSlow => "wipeRightSlow",
                TransitionIn.Zoom => "zoom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransitionIn? ToEnum(string value)
        {
            return value switch
            {
                "carouselDown" => TransitionIn.CarouselDown,
                "carouselDownFast" => TransitionIn.CarouselDownFast,
                "carouselDownSlow" => TransitionIn.CarouselDownSlow,
                "carouselLeft" => TransitionIn.CarouselLeft,
                "carouselLeftFast" => TransitionIn.CarouselLeftFast,
                "carouselLeftSlow" => TransitionIn.CarouselLeftSlow,
                "carouselRight" => TransitionIn.CarouselRight,
                "carouselRightFast" => TransitionIn.CarouselRightFast,
                "carouselRightSlow" => TransitionIn.CarouselRightSlow,
                "carouselUp" => TransitionIn.CarouselUp,
                "carouselUpFast" => TransitionIn.CarouselUpFast,
                "carouselUpSlow" => TransitionIn.CarouselUpSlow,
                "fade" => TransitionIn.Fade,
                "fadeFast" => TransitionIn.FadeFast,
                "fadeSlow" => TransitionIn.FadeSlow,
                "none" => TransitionIn.None,
                "reveal" => TransitionIn.Reveal,
                "revealFast" => TransitionIn.RevealFast,
                "revealSlow" => TransitionIn.RevealSlow,
                "shuffleBottomLeft" => TransitionIn.ShuffleBottomLeft,
                "shuffleBottomLeftFast" => TransitionIn.ShuffleBottomLeftFast,
                "shuffleBottomLeftSlow" => TransitionIn.ShuffleBottomLeftSlow,
                "shuffleBottomRight" => TransitionIn.ShuffleBottomRight,
                "shuffleBottomRightFast" => TransitionIn.ShuffleBottomRightFast,
                "shuffleBottomRightSlow" => TransitionIn.ShuffleBottomRightSlow,
                "shuffleLeftBottom" => TransitionIn.ShuffleLeftBottom,
                "shuffleLeftBottomFast" => TransitionIn.ShuffleLeftBottomFast,
                "shuffleLeftBottomSlow" => TransitionIn.ShuffleLeftBottomSlow,
                "shuffleLeftTop" => TransitionIn.ShuffleLeftTop,
                "shuffleLeftTopFast" => TransitionIn.ShuffleLeftTopFast,
                "shuffleLeftTopSlow" => TransitionIn.ShuffleLeftTopSlow,
                "shuffleRightBottom" => TransitionIn.ShuffleRightBottom,
                "shuffleRightBottomFast" => TransitionIn.ShuffleRightBottomFast,
                "shuffleRightBottomSlow" => TransitionIn.ShuffleRightBottomSlow,
                "shuffleRightTop" => TransitionIn.ShuffleRightTop,
                "shuffleRightTopFast" => TransitionIn.ShuffleRightTopFast,
                "shuffleRightTopSlow" => TransitionIn.ShuffleRightTopSlow,
                "shuffleTopLeft" => TransitionIn.ShuffleTopLeft,
                "shuffleTopLeftFast" => TransitionIn.ShuffleTopLeftFast,
                "shuffleTopLeftSlow" => TransitionIn.ShuffleTopLeftSlow,
                "shuffleTopRight" => TransitionIn.ShuffleTopRight,
                "shuffleTopRightFast" => TransitionIn.ShuffleTopRightFast,
                "shuffleTopRightSlow" => TransitionIn.ShuffleTopRightSlow,
                "slideDown" => TransitionIn.SlideDown,
                "slideDownFast" => TransitionIn.SlideDownFast,
                "slideDownSlow" => TransitionIn.SlideDownSlow,
                "slideLeft" => TransitionIn.SlideLeft,
                "slideLeftFast" => TransitionIn.SlideLeftFast,
                "slideLeftSlow" => TransitionIn.SlideLeftSlow,
                "slideRight" => TransitionIn.SlideRight,
                "slideRightFast" => TransitionIn.SlideRightFast,
                "slideRightSlow" => TransitionIn.SlideRightSlow,
                "slideUp" => TransitionIn.SlideUp,
                "slideUpFast" => TransitionIn.SlideUpFast,
                "slideUpSlow" => TransitionIn.SlideUpSlow,
                "wipeLeft" => TransitionIn.WipeLeft,
                "wipeLeftFast" => TransitionIn.WipeLeftFast,
                "wipeLeftSlow" => TransitionIn.WipeLeftSlow,
                "wipeRight" => TransitionIn.WipeRight,
                "wipeRightFast" => TransitionIn.WipeRightFast,
                "wipeRightSlow" => TransitionIn.WipeRightSlow,
                "zoom" => TransitionIn.Zoom,
                _ => null,
            };
        }
    }
}