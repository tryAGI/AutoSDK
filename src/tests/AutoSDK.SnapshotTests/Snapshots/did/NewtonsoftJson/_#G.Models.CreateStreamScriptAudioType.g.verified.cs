//HintName: G.Models.CreateStreamScriptAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateStreamScriptAudioType
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
    public static class CreateStreamScriptAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStreamScriptAudioType value)
        {
            return value switch
            {
                CreateStreamScriptAudioType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStreamScriptAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateStreamScriptAudioType.Audio,
                _ => null,
            };
        }
    }
}