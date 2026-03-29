//HintName: G.Models.AudioScript3Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioScript3Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioScript3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioScript3Type value)
        {
            return value switch
            {
                AudioScript3Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioScript3Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioScript3Type.Audio,
                _ => null,
            };
        }
    }
}