//HintName: G.Models.CreateSceneRequestDtoScriptAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateSceneRequestDtoScriptAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneRequestDtoScriptAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptAudioType value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateSceneRequestDtoScriptAudioType.Audio,
                _ => null,
            };
        }
    }
}