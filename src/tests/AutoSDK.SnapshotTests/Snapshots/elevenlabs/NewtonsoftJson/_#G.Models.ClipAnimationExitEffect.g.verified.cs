//HintName: G.Models.ClipAnimationExitEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAnimationExitEffect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fade")]
        Fade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="float")]
        Float,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gentle_float")]
        GentleFloat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zoom_in")]
        ZoomIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drop")]
        Drop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide_left")]
        SlideLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide_right")]
        SlideRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide_up")]
        SlideUp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide_down")]
        SlideDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pop")]
        Pop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bounce")]
        Bounce,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spin")]
        Spin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slide_bounce")]
        SlideBounce,
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
                ClipAnimationExitEffect.None => "none",
                ClipAnimationExitEffect.Fade => "fade",
                ClipAnimationExitEffect.Float => "float",
                ClipAnimationExitEffect.GentleFloat => "gentle_float",
                ClipAnimationExitEffect.ZoomIn => "zoom_in",
                ClipAnimationExitEffect.Drop => "drop",
                ClipAnimationExitEffect.SlideLeft => "slide_left",
                ClipAnimationExitEffect.SlideRight => "slide_right",
                ClipAnimationExitEffect.SlideUp => "slide_up",
                ClipAnimationExitEffect.SlideDown => "slide_down",
                ClipAnimationExitEffect.Pop => "pop",
                ClipAnimationExitEffect.Bounce => "bounce",
                ClipAnimationExitEffect.Spin => "spin",
                ClipAnimationExitEffect.SlideBounce => "slide_bounce",
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
                "none" => ClipAnimationExitEffect.None,
                "fade" => ClipAnimationExitEffect.Fade,
                "float" => ClipAnimationExitEffect.Float,
                "gentle_float" => ClipAnimationExitEffect.GentleFloat,
                "zoom_in" => ClipAnimationExitEffect.ZoomIn,
                "drop" => ClipAnimationExitEffect.Drop,
                "slide_left" => ClipAnimationExitEffect.SlideLeft,
                "slide_right" => ClipAnimationExitEffect.SlideRight,
                "slide_up" => ClipAnimationExitEffect.SlideUp,
                "slide_down" => ClipAnimationExitEffect.SlideDown,
                "pop" => ClipAnimationExitEffect.Pop,
                "bounce" => ClipAnimationExitEffect.Bounce,
                "spin" => ClipAnimationExitEffect.Spin,
                "slide_bounce" => ClipAnimationExitEffect.SlideBounce,
                _ => null,
            };
        }
    }
}