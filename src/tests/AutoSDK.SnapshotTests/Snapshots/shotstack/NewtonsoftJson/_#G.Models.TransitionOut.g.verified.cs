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
    [global::System.Runtime.Serialization.DataContract]
    public enum TransitionOut
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