//HintName: G.Models.WidgetEndFeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WidgetEndFeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rating")]
        Rating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetEndFeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetEndFeedbackType value)
        {
            return value switch
            {
                WidgetEndFeedbackType.Rating => "rating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetEndFeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "rating" => WidgetEndFeedbackType.Rating,
                _ => null,
            };
        }
    }
}