//HintName: G.Models.ClipEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A motion effect to apply to the Clip. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`zoomIn` - slow zoom in&lt;/li&gt;<br/>
    ///   &lt;li&gt;`zoomOut` - slow zoom out&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideLeft` - slow slide (pan) left&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideRight` - slow slide (pan) right&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideUp` - slow slide (pan) up&lt;/li&gt;<br/>
    ///   &lt;li&gt;`slideDown` - slow slide (pan) down&lt;/li&gt;<br/>
    /// &lt;/ul&gt; The motion effect speed can also be controlled by appending `Fast` or `Slow` to the effect, e.g. `zoomInFast` or `slideRightSlow`.
    /// </summary>
    public enum ClipEffect
    {
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
        ZoomIn,
        /// <summary>
        /// 
        /// </summary>
        ZoomInFast,
        /// <summary>
        /// 
        /// </summary>
        ZoomInSlow,
        /// <summary>
        /// 
        /// </summary>
        ZoomOut,
        /// <summary>
        /// 
        /// </summary>
        ZoomOutFast,
        /// <summary>
        /// 
        /// </summary>
        ZoomOutSlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipEffect value)
        {
            return value switch
            {
                ClipEffect.SlideDown => "slideDown",
                ClipEffect.SlideDownFast => "slideDownFast",
                ClipEffect.SlideDownSlow => "slideDownSlow",
                ClipEffect.SlideLeft => "slideLeft",
                ClipEffect.SlideLeftFast => "slideLeftFast",
                ClipEffect.SlideLeftSlow => "slideLeftSlow",
                ClipEffect.SlideRight => "slideRight",
                ClipEffect.SlideRightFast => "slideRightFast",
                ClipEffect.SlideRightSlow => "slideRightSlow",
                ClipEffect.SlideUp => "slideUp",
                ClipEffect.SlideUpFast => "slideUpFast",
                ClipEffect.SlideUpSlow => "slideUpSlow",
                ClipEffect.ZoomIn => "zoomIn",
                ClipEffect.ZoomInFast => "zoomInFast",
                ClipEffect.ZoomInSlow => "zoomInSlow",
                ClipEffect.ZoomOut => "zoomOut",
                ClipEffect.ZoomOutFast => "zoomOutFast",
                ClipEffect.ZoomOutSlow => "zoomOutSlow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipEffect? ToEnum(string value)
        {
            return value switch
            {
                "slideDown" => ClipEffect.SlideDown,
                "slideDownFast" => ClipEffect.SlideDownFast,
                "slideDownSlow" => ClipEffect.SlideDownSlow,
                "slideLeft" => ClipEffect.SlideLeft,
                "slideLeftFast" => ClipEffect.SlideLeftFast,
                "slideLeftSlow" => ClipEffect.SlideLeftSlow,
                "slideRight" => ClipEffect.SlideRight,
                "slideRightFast" => ClipEffect.SlideRightFast,
                "slideRightSlow" => ClipEffect.SlideRightSlow,
                "slideUp" => ClipEffect.SlideUp,
                "slideUpFast" => ClipEffect.SlideUpFast,
                "slideUpSlow" => ClipEffect.SlideUpSlow,
                "zoomIn" => ClipEffect.ZoomIn,
                "zoomInFast" => ClipEffect.ZoomInFast,
                "zoomInSlow" => ClipEffect.ZoomInSlow,
                "zoomOut" => ClipEffect.ZoomOut,
                "zoomOutFast" => ClipEffect.ZoomOutFast,
                "zoomOutSlow" => ClipEffect.ZoomOutSlow,
                _ => null,
            };
        }
    }
}