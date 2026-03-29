//HintName: G.Models.InsightControllerRemoveResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerRemoveResponseDiscriminatorType
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
    public static class InsightControllerRemoveResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerRemoveResponseDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerRemoveResponseDiscriminatorType.Bar => "bar",
                InsightControllerRemoveResponseDiscriminatorType.Line => "line",
                InsightControllerRemoveResponseDiscriminatorType.Pie => "pie",
                InsightControllerRemoveResponseDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerRemoveResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerRemoveResponseDiscriminatorType.Bar,
                "line" => InsightControllerRemoveResponseDiscriminatorType.Line,
                "pie" => InsightControllerRemoveResponseDiscriminatorType.Pie,
                "text" => InsightControllerRemoveResponseDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}