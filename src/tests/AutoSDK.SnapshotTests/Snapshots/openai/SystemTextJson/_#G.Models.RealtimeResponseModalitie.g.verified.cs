//HintName: G.Models.RealtimeResponseModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseModalitie
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseModalitie value)
        {
            return value switch
            {
                RealtimeResponseModalitie.Text => "text",
                RealtimeResponseModalitie.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseModalitie? ToEnum(string value)
        {
            return value switch
            {
                "text" => RealtimeResponseModalitie.Text,
                "audio" => RealtimeResponseModalitie.Audio,
                _ => null,
            };
        }
    }
}