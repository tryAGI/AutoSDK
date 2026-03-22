//HintName: G.Models.ClassifyResponseClassificationClassificationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of classification performed<br/>
    /// Included only in responses
    /// </summary>
    public enum ClassifyResponseClassificationClassificationType
    {
        /// <summary>
        /// 
        /// </summary>
        MultiLabel,
        /// <summary>
        /// 
        /// </summary>
        SingleLabel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyResponseClassificationClassificationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyResponseClassificationClassificationType value)
        {
            return value switch
            {
                ClassifyResponseClassificationClassificationType.MultiLabel => "multi-label",
                ClassifyResponseClassificationClassificationType.SingleLabel => "single-label",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyResponseClassificationClassificationType? ToEnum(string value)
        {
            return value switch
            {
                "multi-label" => ClassifyResponseClassificationClassificationType.MultiLabel,
                "single-label" => ClassifyResponseClassificationClassificationType.SingleLabel,
                _ => null,
            };
        }
    }
}