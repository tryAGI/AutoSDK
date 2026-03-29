//HintName: G.Models.UpdateTextInsightFromCallTableDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the Insight.<br/>
    /// It is required to be `text` to create a text insight.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateTextInsightFromCallTableDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTextInsightFromCallTableDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTextInsightFromCallTableDTOType value)
        {
            return value switch
            {
                UpdateTextInsightFromCallTableDTOType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTextInsightFromCallTableDTOType? ToEnum(string value)
        {
            return value switch
            {
                "text" => UpdateTextInsightFromCallTableDTOType.Text,
                _ => null,
            };
        }
    }
}