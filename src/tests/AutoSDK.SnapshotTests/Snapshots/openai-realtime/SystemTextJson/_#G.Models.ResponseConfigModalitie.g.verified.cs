//HintName: G.Models.ResponseConfigModalitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseConfigModalitie
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
    public static class ResponseConfigModalitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseConfigModalitie value)
        {
            return value switch
            {
                ResponseConfigModalitie.Audio => "audio",
                ResponseConfigModalitie.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseConfigModalitie? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ResponseConfigModalitie.Audio,
                "text" => ResponseConfigModalitie.Text,
                _ => null,
            };
        }
    }
}