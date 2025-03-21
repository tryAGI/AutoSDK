//HintName: G.Models.RealtimeServerEventResponseContentPartDonePartType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The content type ("text", "audio").
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeServerEventResponseContentPartDonePartType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseContentPartDonePartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseContentPartDonePartType value)
        {
            return value switch
            {
                RealtimeServerEventResponseContentPartDonePartType.Audio => "audio",
                RealtimeServerEventResponseContentPartDonePartType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseContentPartDonePartType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeServerEventResponseContentPartDonePartType.Audio,
                "text" => RealtimeServerEventResponseContentPartDonePartType.Text,
                _ => null,
            };
        }
    }
}