//HintName: G.Models.RealtimeSessionCreateResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeSessionCreateResponseModalitie
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
    public static class RealtimeSessionCreateResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseModalitie value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseModalitie.Text => "text",
                RealtimeSessionCreateResponseModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeSessionCreateResponseModalitie.Text,
                "audio" => RealtimeSessionCreateResponseModalitie.Audio,
                _ => null,
            };
        }
    }
}