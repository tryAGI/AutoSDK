//HintName: G.Models.RealtimeSessionCreateResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Text,
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
                RealtimeSessionCreateResponseModalitie.Audio => "audio",
                RealtimeSessionCreateResponseModalitie.Text => "text",
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
                "audio" => RealtimeSessionCreateResponseModalitie.Audio,
                "text" => RealtimeSessionCreateResponseModalitie.Text,
                _ => null,
            };
        }
    }
}