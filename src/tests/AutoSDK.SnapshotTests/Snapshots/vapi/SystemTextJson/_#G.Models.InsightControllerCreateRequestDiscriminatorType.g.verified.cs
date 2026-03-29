//HintName: G.Models.InsightControllerCreateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerCreateRequestDiscriminatorType
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
    public static class InsightControllerCreateRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerCreateRequestDiscriminatorType value)
        {
            return value switch
            {
                InsightControllerCreateRequestDiscriminatorType.Bar => "bar",
                InsightControllerCreateRequestDiscriminatorType.Line => "line",
                InsightControllerCreateRequestDiscriminatorType.Pie => "pie",
                InsightControllerCreateRequestDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerCreateRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => InsightControllerCreateRequestDiscriminatorType.Bar,
                "line" => InsightControllerCreateRequestDiscriminatorType.Line,
                "pie" => InsightControllerCreateRequestDiscriminatorType.Pie,
                "text" => InsightControllerCreateRequestDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}