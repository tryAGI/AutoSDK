//HintName: G.Models.OutputAudioType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the output audio. Always `output_audio`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputAudioType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output_audio")]
        OutputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputAudioType value)
        {
            return value switch
            {
                OutputAudioType.OutputAudio => "output_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputAudioType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio" => OutputAudioType.OutputAudio,
                _ => null,
            };
        }
    }
}