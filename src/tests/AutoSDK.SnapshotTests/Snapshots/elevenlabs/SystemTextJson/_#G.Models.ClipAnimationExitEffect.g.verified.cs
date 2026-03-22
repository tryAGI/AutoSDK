//HintName: G.Models.ClipAnimationExitEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    public enum ClipAnimationExitEffect
    {
        /// <summary>
        /// 
        /// </summary>
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        Drop,
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        GentleFloat,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Pop,
        /// <summary>
        /// 
        /// </summary>
        SlideBounce,
        /// <summary>
        /// 
        /// </summary>
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        SlideLeft,
        /// <summary>
        /// 
        /// </summary>
        SlideRight,
        /// <summary>
        /// 
        /// </summary>
        SlideUp,
        /// <summary>
        /// 
        /// </summary>
        Spin,
        /// <summary>
        /// 
        /// </summary>
        ZoomIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipAnimationExitEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAnimationExitEffect value)
        {
            return value switch
            {
                ClipAnimationExitEffect.Bounce => "bounce",
                ClipAnimationExitEffect.Drop => "drop",
                ClipAnimationExitEffect.Fade => "fade",
                ClipAnimationExitEffect.Float => "float",
                ClipAnimationExitEffect.GentleFloat => "gentle_float",
                ClipAnimationExitEffect.None => "none",
                ClipAnimationExitEffect.Pop => "pop",
                ClipAnimationExitEffect.SlideBounce => "slide_bounce",
                ClipAnimationExitEffect.SlideDown => "slide_down",
                ClipAnimationExitEffect.SlideLeft => "slide_left",
                ClipAnimationExitEffect.SlideRight => "slide_right",
                ClipAnimationExitEffect.SlideUp => "slide_up",
                ClipAnimationExitEffect.Spin => "spin",
                ClipAnimationExitEffect.ZoomIn => "zoom_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAnimationExitEffect? ToEnum(string value)
        {
            return value switch
            {
                "bounce" => ClipAnimationExitEffect.Bounce,
                "drop" => ClipAnimationExitEffect.Drop,
                "fade" => ClipAnimationExitEffect.Fade,
                "float" => ClipAnimationExitEffect.Float,
                "gentle_float" => ClipAnimationExitEffect.GentleFloat,
                "none" => ClipAnimationExitEffect.None,
                "pop" => ClipAnimationExitEffect.Pop,
                "slide_bounce" => ClipAnimationExitEffect.SlideBounce,
                "slide_down" => ClipAnimationExitEffect.SlideDown,
                "slide_left" => ClipAnimationExitEffect.SlideLeft,
                "slide_right" => ClipAnimationExitEffect.SlideRight,
                "slide_up" => ClipAnimationExitEffect.SlideUp,
                "spin" => ClipAnimationExitEffect.Spin,
                "zoom_in" => ClipAnimationExitEffect.ZoomIn,
                _ => null,
            };
        }
    }
}