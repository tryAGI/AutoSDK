//HintName: G.Models.TweenEasing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The easing function to use for the animation. Easing controls the rate of change of the animated value, allowing for more natural motion by speeding up or slowing down the animation at different points. Only applicable if interpolation is set to `bezier`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TweenEasing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ease")]
        Ease,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeIn")]
        EaseIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInBack")]
        EaseInBack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInCirc")]
        EaseInCirc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInCubic")]
        EaseInCubic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInExpo")]
        EaseInExpo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOut")]
        EaseInOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutBack")]
        EaseInOutBack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutCirc")]
        EaseInOutCirc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutCubic")]
        EaseInOutCubic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutExpo")]
        EaseInOutExpo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutQuad")]
        EaseInOutQuad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutQuart")]
        EaseInOutQuart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutQuint")]
        EaseInOutQuint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInOutSine")]
        EaseInOutSine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInQuad")]
        EaseInQuad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInQuart")]
        EaseInQuart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInQuint")]
        EaseInQuint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeInSine")]
        EaseInSine,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOut")]
        EaseOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutBack")]
        EaseOutBack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutCirc")]
        EaseOutCirc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutCubic")]
        EaseOutCubic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutExpo")]
        EaseOutExpo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutQuad")]
        EaseOutQuad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutQuart")]
        EaseOutQuart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutQuint")]
        EaseOutQuint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="easeOutSine")]
        EaseOutSine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TweenEasingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TweenEasing value)
        {
            return value switch
            {
                TweenEasing.Ease => "ease",
                TweenEasing.EaseIn => "easeIn",
                TweenEasing.EaseInBack => "easeInBack",
                TweenEasing.EaseInCirc => "easeInCirc",
                TweenEasing.EaseInCubic => "easeInCubic",
                TweenEasing.EaseInExpo => "easeInExpo",
                TweenEasing.EaseInOut => "easeInOut",
                TweenEasing.EaseInOutBack => "easeInOutBack",
                TweenEasing.EaseInOutCirc => "easeInOutCirc",
                TweenEasing.EaseInOutCubic => "easeInOutCubic",
                TweenEasing.EaseInOutExpo => "easeInOutExpo",
                TweenEasing.EaseInOutQuad => "easeInOutQuad",
                TweenEasing.EaseInOutQuart => "easeInOutQuart",
                TweenEasing.EaseInOutQuint => "easeInOutQuint",
                TweenEasing.EaseInOutSine => "easeInOutSine",
                TweenEasing.EaseInQuad => "easeInQuad",
                TweenEasing.EaseInQuart => "easeInQuart",
                TweenEasing.EaseInQuint => "easeInQuint",
                TweenEasing.EaseInSine => "easeInSine",
                TweenEasing.EaseOut => "easeOut",
                TweenEasing.EaseOutBack => "easeOutBack",
                TweenEasing.EaseOutCirc => "easeOutCirc",
                TweenEasing.EaseOutCubic => "easeOutCubic",
                TweenEasing.EaseOutExpo => "easeOutExpo",
                TweenEasing.EaseOutQuad => "easeOutQuad",
                TweenEasing.EaseOutQuart => "easeOutQuart",
                TweenEasing.EaseOutQuint => "easeOutQuint",
                TweenEasing.EaseOutSine => "easeOutSine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TweenEasing? ToEnum(string value)
        {
            return value switch
            {
                "ease" => TweenEasing.Ease,
                "easeIn" => TweenEasing.EaseIn,
                "easeInBack" => TweenEasing.EaseInBack,
                "easeInCirc" => TweenEasing.EaseInCirc,
                "easeInCubic" => TweenEasing.EaseInCubic,
                "easeInExpo" => TweenEasing.EaseInExpo,
                "easeInOut" => TweenEasing.EaseInOut,
                "easeInOutBack" => TweenEasing.EaseInOutBack,
                "easeInOutCirc" => TweenEasing.EaseInOutCirc,
                "easeInOutCubic" => TweenEasing.EaseInOutCubic,
                "easeInOutExpo" => TweenEasing.EaseInOutExpo,
                "easeInOutQuad" => TweenEasing.EaseInOutQuad,
                "easeInOutQuart" => TweenEasing.EaseInOutQuart,
                "easeInOutQuint" => TweenEasing.EaseInOutQuint,
                "easeInOutSine" => TweenEasing.EaseInOutSine,
                "easeInQuad" => TweenEasing.EaseInQuad,
                "easeInQuart" => TweenEasing.EaseInQuart,
                "easeInQuint" => TweenEasing.EaseInQuint,
                "easeInSine" => TweenEasing.EaseInSine,
                "easeOut" => TweenEasing.EaseOut,
                "easeOutBack" => TweenEasing.EaseOutBack,
                "easeOutCirc" => TweenEasing.EaseOutCirc,
                "easeOutCubic" => TweenEasing.EaseOutCubic,
                "easeOutExpo" => TweenEasing.EaseOutExpo,
                "easeOutQuad" => TweenEasing.EaseOutQuad,
                "easeOutQuart" => TweenEasing.EaseOutQuart,
                "easeOutQuint" => TweenEasing.EaseOutQuint,
                "easeOutSine" => TweenEasing.EaseOutSine,
                _ => null,
            };
        }
    }
}