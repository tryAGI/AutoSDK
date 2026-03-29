//HintName: G.Models.InsightControllerFindOneResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerFindOneResponseDiscriminatorType
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
    public static class InsightControllerFindOneResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerFindOneResponseDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerFindOneResponseDiscriminatorType.Bar => "bar",
                InsightControllerFindOneResponseDiscriminatorType.Line => "line",
                InsightControllerFindOneResponseDiscriminatorType.Pie => "pie",
                InsightControllerFindOneResponseDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerFindOneResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerFindOneResponseDiscriminatorType.Bar,
                "line" => InsightControllerFindOneResponseDiscriminatorType.Line,
                "pie" => InsightControllerFindOneResponseDiscriminatorType.Pie,
                "text" => InsightControllerFindOneResponseDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}