//HintName: G.Models.ClipAnimationEnterEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    public enum ClipAnimationEnterEffect
    {
        /// <summary>
        /// 
        /// </summary>
        None,
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
        ZoomIn,
        /// <summary>
        /// 
        /// </summary>
        Drop,
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
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        Pop,
        /// <summary>
        /// 
        /// </summary>
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        Spin,
        /// <summary>
        /// 
        /// </summary>
        SlideBounce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipAnimationEnterEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAnimationEnterEffect value)
        {
            return value switch
            {
                ClipAnimationEnterEffect.None => "none",
                ClipAnimationEnterEffect.Fade => "fade",
                ClipAnimationEnterEffect.Float => "float",
                ClipAnimationEnterEffect.GentleFloat => "gentle_float",
                ClipAnimationEnterEffect.ZoomIn => "zoom_in",
                ClipAnimationEnterEffect.Drop => "drop",
                ClipAnimationEnterEffect.SlideLeft => "slide_left",
                ClipAnimationEnterEffect.SlideRight => "slide_right",
                ClipAnimationEnterEffect.SlideUp => "slide_up",
                ClipAnimationEnterEffect.SlideDown => "slide_down",
                ClipAnimationEnterEffect.Pop => "pop",
                ClipAnimationEnterEffect.Bounce => "bounce",
                ClipAnimationEnterEffect.Spin => "spin",
                ClipAnimationEnterEffect.SlideBounce => "slide_bounce",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAnimationEnterEffect? ToEnum(string value)
        {
            return value switch
            {
                "none" => ClipAnimationEnterEffect.None,
                "fade" => ClipAnimationEnterEffect.Fade,
                "float" => ClipAnimationEnterEffect.Float,
                "gentle_float" => ClipAnimationEnterEffect.GentleFloat,
                "zoom_in" => ClipAnimationEnterEffect.ZoomIn,
                "drop" => ClipAnimationEnterEffect.Drop,
                "slide_left" => ClipAnimationEnterEffect.SlideLeft,
                "slide_right" => ClipAnimationEnterEffect.SlideRight,
                "slide_up" => ClipAnimationEnterEffect.SlideUp,
                "slide_down" => ClipAnimationEnterEffect.SlideDown,
                "pop" => ClipAnimationEnterEffect.Pop,
                "bounce" => ClipAnimationEnterEffect.Bounce,
                "spin" => ClipAnimationEnterEffect.Spin,
                "slide_bounce" => ClipAnimationEnterEffect.SlideBounce,
                _ => null,
            };
        }
    }
}