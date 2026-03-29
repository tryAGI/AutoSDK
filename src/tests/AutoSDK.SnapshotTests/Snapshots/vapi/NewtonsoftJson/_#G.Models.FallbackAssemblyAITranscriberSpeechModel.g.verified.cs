//HintName: G.Models.FallbackAssemblyAITranscriberSpeechModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the speech model used for the streaming session.<br/>
    /// Note: Keyterms prompting is not supported with multilingual streaming.<br/>
    /// @default 'universal-streaming-english'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackAssemblyAITranscriberSpeechModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="universal-streaming-english")]
        UniversalStreamingEnglish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="universal-streaming-multilingual")]
        UniversalStreamingMultilingual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAssemblyAITranscriberSpeechModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAssemblyAITranscriberSpeechModel value)
        {
            return value switch
            {
                FallbackAssemblyAITranscriberSpeechModel.UniversalStreamingEnglish => "universal-streaming-english",
                FallbackAssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual => "universal-streaming-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAssemblyAITranscriberSpeechModel? ToEnum(string value)
        {
            return value switch
            {
                "universal-streaming-english" => FallbackAssemblyAITranscriberSpeechModel.UniversalStreamingEnglish,
                "universal-streaming-multilingual" => FallbackAssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual,
                _ => null,
            };
        }
    }
}