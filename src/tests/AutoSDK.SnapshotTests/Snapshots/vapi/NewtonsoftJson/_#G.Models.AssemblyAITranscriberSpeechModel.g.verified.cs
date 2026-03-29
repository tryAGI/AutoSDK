//HintName: G.Models.AssemblyAITranscriberSpeechModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the speech model used for the streaming session.<br/>
    /// Note: Keyterms prompting is not supported with multilingual streaming.<br/>
    /// @default 'universal-streaming-english'
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssemblyAITranscriberSpeechModel
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
    public static class AssemblyAITranscriberSpeechModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberSpeechModel value)
        {
            return value switch
            {
                AssemblyAITranscriberSpeechModel.UniversalStreamingEnglish => "universal-streaming-english",
                AssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual => "universal-streaming-multilingual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberSpeechModel? ToEnum(string value)
        {
            return value switch
            {
                "universal-streaming-english" => AssemblyAITranscriberSpeechModel.UniversalStreamingEnglish,
                "universal-streaming-multilingual" => AssemblyAITranscriberSpeechModel.UniversalStreamingMultilingual,
                _ => null,
            };
        }
    }
}