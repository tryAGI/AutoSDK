//HintName: G.Models.InsightControllerUpdateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerUpdateResponseDiscriminatorType
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
    public static class InsightControllerUpdateResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerUpdateResponseDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerUpdateResponseDiscriminatorType.Bar => "bar",
                InsightControllerUpdateResponseDiscriminatorType.Line => "line",
                InsightControllerUpdateResponseDiscriminatorType.Pie => "pie",
                InsightControllerUpdateResponseDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerUpdateResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerUpdateResponseDiscriminatorType.Bar,
                "line" => InsightControllerUpdateResponseDiscriminatorType.Line,
                "pie" => InsightControllerUpdateResponseDiscriminatorType.Pie,
                "text" => InsightControllerUpdateResponseDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}