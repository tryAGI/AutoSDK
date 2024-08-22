//HintName: G.Models.CustomChartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for custom chart types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomChartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar")]
        Bar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartType value)
        {
            return value switch
            {
                CustomChartType.Line => "line",
                CustomChartType.Bar => "bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartType? ToEnum(string value)
        {
            return value switch
            {
                "line" => CustomChartType.Line,
                "bar" => CustomChartType.Bar,
                _ => null,
            };
        }
    }
}