//HintName: G.Models.UpdateBarInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `bar` to create a bar insight.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateBarInsightFromCallTableDTOType
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
    public static class UpdateBarInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBarInsightFromCallTableDTOType value)
        {
            return value switch
            {
                UpdateBarInsightFromCallTableDTOType.Bar => "bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBarInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => UpdateBarInsightFromCallTableDTOType.Bar,
                _ => null,
            };
        }
    }
}