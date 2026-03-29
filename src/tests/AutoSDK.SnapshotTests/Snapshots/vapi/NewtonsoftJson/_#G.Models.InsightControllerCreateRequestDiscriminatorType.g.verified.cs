//HintName: G.Models.InsightControllerCreateRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InsightControllerCreateRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar")]
        Bar,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pie")]
        Pie,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
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