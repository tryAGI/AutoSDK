//HintName: G.Models.ClassifyResponseClassificationClassificationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of classification performed
    /// </summary>
    public enum ClassifyResponseClassificationClassificationType
    {
        /// <summary>
        /// 
        /// </summary>
        SingleLabel,
        /// <summary>
        /// 
        /// </summary>
        MultiLabel,
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
                ClassifyResponseClassificationClassificationType.SingleLabel => "single-label",
                ClassifyResponseClassificationClassificationType.MultiLabel => "multi-label",
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
                "single-label" => ClassifyResponseClassificationClassificationType.SingleLabel,
                "multi-label" => ClassifyResponseClassificationClassificationType.MultiLabel,
                _ => null,
            };
        }
    }
}