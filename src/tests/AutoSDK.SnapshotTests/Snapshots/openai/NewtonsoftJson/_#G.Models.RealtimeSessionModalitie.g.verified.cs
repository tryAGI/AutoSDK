//HintName: G.Models.RealtimeSessionModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: [text, audio]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionModalitie
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
    public static class RealtimeSessionModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionModalitie value)
        {
            return value switch
            {
                RealtimeSessionModalitie.Text => "text",
                RealtimeSessionModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionModalitie.Text,
                "audio" => RealtimeSessionModalitie.Audio,
                _ => null,
            };
        }
    }
}