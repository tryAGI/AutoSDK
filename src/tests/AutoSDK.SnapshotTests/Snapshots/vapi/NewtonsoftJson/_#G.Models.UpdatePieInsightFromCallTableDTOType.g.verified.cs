//HintName: G.Models.UpdatePieInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `pie` to create a pie insight.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePieInsightFromCallTableDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pie")]
        Pie,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePieInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePieInsightFromCallTableDTOType value)
        {
            return value switch
            {
                UpdatePieInsightFromCallTableDTOType.Pie => "pie",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePieInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "pie" => UpdatePieInsightFromCallTableDTOType.Pie,
                _ => null,
            };
        }
    }
}