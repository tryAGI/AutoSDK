//HintName: G.Models.CreateTranscriptionRequestChunkingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Automatically set chunking parameters based on the audio. Must be set to `"auto"`.<br/>
    /// Default Value: [auto]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranscriptionRequestChunkingStrategy
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
    public static class CreateTranscriptionRequestChunkingStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionRequestChunkingStrategy value)
        {
            return value switch
            {
                CreateTranscriptionRequestChunkingStrategy.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionRequestChunkingStrategy? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateTranscriptionRequestChunkingStrategy.Auto,
                _ => null,
            };
        }
    }
}