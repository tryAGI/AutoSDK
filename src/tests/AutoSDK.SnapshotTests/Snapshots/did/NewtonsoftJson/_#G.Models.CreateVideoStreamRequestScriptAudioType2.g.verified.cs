//HintName: G.Models.CreateVideoStreamRequestScriptAudioType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoStreamRequestScriptAudioType2
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
    public static class CreateVideoStreamRequestScriptAudioType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoStreamRequestScriptAudioType2 value)
        {
            return value switch
            {
                CreateVideoStreamRequestScriptAudioType2.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoStreamRequestScriptAudioType2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateVideoStreamRequestScriptAudioType2.Audio,
                _ => null,
            };
        }
    }
}