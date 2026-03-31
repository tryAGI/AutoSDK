//HintName: G.Models.CreateVideoStreamRequestScriptAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateVideoStreamRequestScriptAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoStreamRequestScriptAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptAudioType value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateVideoStreamRequestScriptAudioType.Audio,
                _ => null,
            };
        }
    }
}