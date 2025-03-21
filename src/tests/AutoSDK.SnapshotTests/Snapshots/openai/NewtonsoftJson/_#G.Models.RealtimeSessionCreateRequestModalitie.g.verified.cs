//HintName: G.Models.RealtimeSessionCreateRequestModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateRequestModalitie
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
    public static class RealtimeSessionCreateRequestModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestModalitie.Text => "text",
                RealtimeSessionCreateRequestModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionCreateRequestModalitie.Text,
                "audio" => RealtimeSessionCreateRequestModalitie.Audio,
                _ => null,
            };
        }
    }
}