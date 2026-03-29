//HintName: G.Models.BarInsightFromCallTableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `bar` to create a bar insight.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BarInsightFromCallTableType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bar")]
        Bar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BarInsightFromCallTableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BarInsightFromCallTableType value)
        {
            return value switch
            {
                BarInsightFromCallTableType.Bar => "bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BarInsightFromCallTableType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => BarInsightFromCallTableType.Bar,
                _ => null,
            };
        }
    }
}