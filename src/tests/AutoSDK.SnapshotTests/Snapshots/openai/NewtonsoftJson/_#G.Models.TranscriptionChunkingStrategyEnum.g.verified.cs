//HintName: G.Models.TranscriptionChunkingStrategyEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Automatically set chunking parameters based on the audio. Must be set to `"auto"`.<br/>
    /// Default Value: [auto]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionChunkingStrategyEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionChunkingStrategyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionChunkingStrategyEnum value)
        {
            return value switch
            {
                TranscriptionChunkingStrategyEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionChunkingStrategyEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => TranscriptionChunkingStrategyEnum.Auto,
                _ => null,
            };
        }
    }
}