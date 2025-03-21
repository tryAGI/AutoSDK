//HintName: G.Models.RealtimeResponseCreateParamsModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeResponseCreateParamsModalitie
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
    public static class RealtimeResponseCreateParamsModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsModalitie value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsModalitie.Text => "text",
                RealtimeResponseCreateParamsModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeResponseCreateParamsModalitie.Text,
                "audio" => RealtimeResponseCreateParamsModalitie.Audio,
                _ => null,
            };
        }
    }
}