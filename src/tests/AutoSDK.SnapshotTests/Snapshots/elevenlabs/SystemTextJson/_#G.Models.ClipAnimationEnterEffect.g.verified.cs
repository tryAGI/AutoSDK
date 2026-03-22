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
    public static class ClipAnimationEnterEffectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAnimationEnterEffect value)
        {
            return value switch
            {
                ClipAnimationEnterEffect.Bounce => "bounce",
                ClipAnimationEnterEffect.Drop => "drop",
                ClipAnimationEnterEffect.Fade => "fade",
                ClipAnimationEnterEffect.Float => "float",
                ClipAnimationEnterEffect.GentleFloat => "gentle_float",
                ClipAnimationEnterEffect.None => "none",
                ClipAnimationEnterEffect.Pop => "pop",
                ClipAnimationEnterEffect.SlideBounce => "slide_bounce",
                ClipAnimationEnterEffect.SlideDown => "slide_down",
                ClipAnimationEnterEffect.SlideLeft => "slide_left",
                ClipAnimationEnterEffect.SlideRight => "slide_right",
                ClipAnimationEnterEffect.SlideUp => "slide_up",
                ClipAnimationEnterEffect.Spin => "spin",
                ClipAnimationEnterEffect.ZoomIn => "zoom_in",
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
                "bounce" => ClipAnimationEnterEffect.Bounce,
                "drop" => ClipAnimationEnterEffect.Drop,
                "fade" => ClipAnimationEnterEffect.Fade,
                "float" => ClipAnimationEnterEffect.Float,
                "gentle_float" => ClipAnimationEnterEffect.GentleFloat,
                "none" => ClipAnimationEnterEffect.None,
                "pop" => ClipAnimationEnterEffect.Pop,
                "slide_bounce" => ClipAnimationEnterEffect.SlideBounce,
                "slide_down" => ClipAnimationEnterEffect.SlideDown,
                "slide_left" => ClipAnimationEnterEffect.SlideLeft,
                "slide_right" => ClipAnimationEnterEffect.SlideRight,
                "slide_up" => ClipAnimationEnterEffect.SlideUp,
                "spin" => ClipAnimationEnterEffect.Spin,
                "zoom_in" => ClipAnimationEnterEffect.ZoomIn,
                _ => null,
            };
        }
    }
}