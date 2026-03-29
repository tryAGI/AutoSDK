//HintName: G.Models.AudioScriptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioScriptType
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
    public static class AudioScriptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioScriptType value)
        {
            return value switch
            {
                AudioScriptType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioScriptType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioScriptType.Audio,
                _ => null,
            };
        }
    }
}