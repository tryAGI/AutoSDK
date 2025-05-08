//HintName: G.Models.RealtimeTranscriptionSessionCreateResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeTranscriptionSessionCreateResponseModalitie
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
    public static class RealtimeTranscriptionSessionCreateResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseModalitie value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseModalitie.Text => "text",
                RealtimeTranscriptionSessionCreateResponseModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeTranscriptionSessionCreateResponseModalitie.Text,
                "audio" => RealtimeTranscriptionSessionCreateResponseModalitie.Audio,
                _ => null,
            };
        }
    }
}