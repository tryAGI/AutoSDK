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
    [global::System.Runtime.Serialization.DataContract]
    public enum TransitionIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselDown")]
        CarouselDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselDownFast")]
        CarouselDownFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselDownSlow")]
        CarouselDownSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselLeft")]
        CarouselLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselLeftFast")]
        CarouselLeftFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselLeftSlow")]
        CarouselLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselRight")]
        CarouselRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselRightFast")]
        CarouselRightFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselRightSlow")]
        CarouselRightSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselUp")]
        CarouselUp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselUpFast")]
        CarouselUpFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="carouselUpSlow")]
        CarouselUpSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fade")]
        Fade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeFast")]
        FadeFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fadeSlow")]
        FadeSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reveal")]
        Reveal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="revealFast")]
        RevealFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="revealSlow")]
        RevealSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomLeft")]
        ShuffleBottomLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomLeftFast")]
        ShuffleBottomLeftFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomLeftSlow")]
        ShuffleBottomLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomRight")]
        ShuffleBottomRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomRightFast")]
        ShuffleBottomRightFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleBottomRightSlow")]
        ShuffleBottomRightSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftBottom")]
        ShuffleLeftBottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftBottomFast")]
        ShuffleLeftBottomFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftBottomSlow")]
        ShuffleLeftBottomSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftTop")]
        ShuffleLeftTop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftTopFast")]
        ShuffleLeftTopFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleLeftTopSlow")]
        ShuffleLeftTopSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightBottom")]
        ShuffleRightBottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightBottomFast")]
        ShuffleRightBottomFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightBottomSlow")]
        ShuffleRightBottomSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightTop")]
        ShuffleRightTop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightTopFast")]
        ShuffleRightTopFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleRightTopSlow")]
        ShuffleRightTopSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopLeft")]
        ShuffleTopLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopLeftFast")]
        ShuffleTopLeftFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopLeftSlow")]
        ShuffleTopLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopRight")]
        ShuffleTopRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopRightFast")]
        ShuffleTopRightFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shuffleTopRightSlow")]
        ShuffleTopRightSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideDown")]
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideDownFast")]
        SlideDownFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideDownSlow")]
        SlideDownSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideLeft")]
        SlideLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideLeftFast")]
        SlideLeftFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideLeftSlow")]
        SlideLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideRight")]
        SlideRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideRightFast")]
        SlideRightFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideRightSlow")]
        SlideRightSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideUp")]
        SlideUp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideUpFast")]
        SlideUpFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slideUpSlow")]
        SlideUpSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeLeft")]
        WipeLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeLeftFast")]
        WipeLeftFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeLeftSlow")]
        WipeLeftSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeRight")]
        WipeRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeRightFast")]
        WipeRightFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wipeRightSlow")]
        WipeRightSlow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zoom")]
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