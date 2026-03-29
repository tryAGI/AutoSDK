//HintName: G.Models.InsightControllerCreateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerCreateResponseDiscriminatorType
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
    public static class InsightControllerCreateResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerCreateResponseDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerCreateResponseDiscriminatorType.Bar => "bar",
                InsightControllerCreateResponseDiscriminatorType.Line => "line",
                InsightControllerCreateResponseDiscriminatorType.Pie => "pie",
                InsightControllerCreateResponseDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerCreateResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerCreateResponseDiscriminatorType.Bar,
                "line" => InsightControllerCreateResponseDiscriminatorType.Line,
                "pie" => InsightControllerCreateResponseDiscriminatorType.Pie,
                "text" => InsightControllerCreateResponseDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}