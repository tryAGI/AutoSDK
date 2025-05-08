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
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
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
                RealtimeTranscriptionSessionCreateRequestModalitie.Text => "text",
                RealtimeTranscriptionSessionCreateRequestModalitie.Audio => "audio",
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
                "text" => RealtimeTranscriptionSessionCreateRequestModalitie.Text,
                "audio" => RealtimeTranscriptionSessionCreateRequestModalitie.Audio,
                _ => null,
            };
        }
    }
}