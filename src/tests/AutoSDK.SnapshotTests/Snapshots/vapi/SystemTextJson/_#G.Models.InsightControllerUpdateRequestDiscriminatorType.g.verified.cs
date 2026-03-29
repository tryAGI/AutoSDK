//HintName: G.Models.InsightControllerUpdateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerUpdateRequestDiscriminatorType
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
    public static class InsightControllerUpdateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerUpdateRequestDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerUpdateRequestDiscriminatorType.Bar => "bar",
                InsightControllerUpdateRequestDiscriminatorType.Line => "line",
                InsightControllerUpdateRequestDiscriminatorType.Pie => "pie",
                InsightControllerUpdateRequestDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerUpdateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerUpdateRequestDiscriminatorType.Bar,
                "line" => InsightControllerUpdateRequestDiscriminatorType.Line,
                "pie" => InsightControllerUpdateRequestDiscriminatorType.Pie,
                "text" => InsightControllerUpdateRequestDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}