//HintName: G.Models.InputAudioAppendType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be 'input_audio.append'.
    /// </summary>
    public enum InputAudioAppendType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputAudioAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioAppendType value)
        {
            return value switch
            {
                InputAudioAppendType.InputAudioAppend => "input_audio.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioAppendType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio.append" => InputAudioAppendType.InputAudioAppend,
                _ => null,
            };
        }
    }
}