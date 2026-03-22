//HintName: G.Models.RealtimeTranscriptionSessionCreateRequestModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: [text, audio]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateRequestModalitie
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
    public static class RealtimeTranscriptionSessionCreateRequestModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestModalitie value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestModalitie.Audio => "audio",
                RealtimeTranscriptionSessionCreateRequestModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => RealtimeTranscriptionSessionCreateRequestModalitie.Audio,
                "text" => RealtimeTranscriptionSessionCreateRequestModalitie.Text,
                _ => null,
            };
        }
    }
}