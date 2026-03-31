//HintName: G.Models.Create2RequestScriptAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum Create2RequestScriptAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptAudioType value)
        {
            return value switch
            {
                Create2RequestScriptAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => Create2RequestScriptAudioType.Audio,
                _ => null,
            };
        }
    }
}