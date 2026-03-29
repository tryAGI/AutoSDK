//HintName: G.Models.FeedbackMetricSpecValueType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of value at path. numeric: avg/min/max; boolean: count_true/count_false.<br/>
    /// Default Value: numeric
    /// </summary>
    public enum FeedbackMetricSpecValueType
    {
        /// <summary>
        /// avg/min/max; boolean: count_true/count_false.
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// avg/min/max; boolean: count_true/count_false.
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackMetricSpecValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackMetricSpecValueType value)
        {
            return value switch
            {
                FeedbackMetricSpecValueType.Boolean => "boolean",
                FeedbackMetricSpecValueType.Categorical => "categorical",
                FeedbackMetricSpecValueType.Numeric => "numeric",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackMetricSpecValueType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackMetricSpecValueType.Boolean,
                "categorical" => FeedbackMetricSpecValueType.Categorical,
                "numeric" => FeedbackMetricSpecValueType.Numeric,
                _ => null,
            };
        }
    }
}