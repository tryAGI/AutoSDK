//HintName: G.Models.InputAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the input item. Always `input_audio`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_audio")]
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioType value)
        {
            return value switch
            {
                InputAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => InputAudioType.InputAudio,
                _ => null,
            };
        }
    }
}