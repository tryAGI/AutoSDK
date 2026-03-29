//HintName: G.Models.InsightControllerPreviewRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerPreviewRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bar,
        /// <summary>
        /// 
        /// </summary>
        Line,
        /// <summary>
        /// 
        /// </summary>
        Pie,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InsightControllerPreviewRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerPreviewRequestDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerPreviewRequestDiscriminatorType.Bar => "bar",
                InsightControllerPreviewRequestDiscriminatorType.Line => "line",
                InsightControllerPreviewRequestDiscriminatorType.Pie => "pie",
                InsightControllerPreviewRequestDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerPreviewRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerPreviewRequestDiscriminatorType.Bar,
                "line" => InsightControllerPreviewRequestDiscriminatorType.Line,
                "pie" => InsightControllerPreviewRequestDiscriminatorType.Pie,
                "text" => InsightControllerPreviewRequestDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}