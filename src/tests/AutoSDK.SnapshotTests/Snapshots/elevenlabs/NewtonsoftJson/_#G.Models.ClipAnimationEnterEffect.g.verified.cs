//HintName: G.Models.ClipAnimationEnterEffect.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAnimationEnterEffect
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