//HintName: G.Models.InsightControllerUpdateResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InsightControllerUpdateResponseDiscriminatorType
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