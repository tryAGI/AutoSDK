//HintName: G.Models.RichCaptionAnimationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Direction for directional animations (slide). Only applicable when style is `slide`.<br/>
    /// Default Value: up<br/>
    /// Example: up
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichCaptionAnimationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="down")]
        Down,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="up")]
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionAnimationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionAnimationDirection value)
        {
            return value switch
            {
                RichCaptionAnimationDirection.Down => "down",
                RichCaptionAnimationDirection.Left => "left",
                RichCaptionAnimationDirection.Right => "right",
                RichCaptionAnimationDirection.Up => "up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionAnimationDirection? ToEnum(string value)
        {
            return value switch
            {
                "down" => RichCaptionAnimationDirection.Down,
                "left" => RichCaptionAnimationDirection.Left,
                "right" => RichCaptionAnimationDirection.Right,
                "up" => RichCaptionAnimationDirection.Up,
                _ => null,
            };
        }
    }
}