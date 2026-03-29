//HintName: G.Models.FeedbackPayloadPathValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inferred type of value at path.<br/>
    /// Default Value: numeric
    /// </summary>
    public enum FeedbackPayloadPathValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackPayloadPathValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackPayloadPathValueType value)
        {
            return value switch
            {
                FeedbackPayloadPathValueType.Boolean => "boolean",
                FeedbackPayloadPathValueType.Categorical => "categorical",
                FeedbackPayloadPathValueType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackPayloadPathValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackPayloadPathValueType.Boolean,
                "categorical" => FeedbackPayloadPathValueType.Categorical,
                "numeric" => FeedbackPayloadPathValueType.Numeric,
                _ => null,
            };
        }
    }
}