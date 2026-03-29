//HintName: G.Models.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: automatic single language
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automatic multiple languages")]
        AutomaticMultipleLanguages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automatic single language")]
        AutomaticSingleLanguage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manual")]
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour value)
        {
            return value switch
            {
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages => "automatic multiple languages",
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage => "automatic single language",
                AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "automatic multiple languages" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticMultipleLanguages,
                "automatic single language" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.AutomaticSingleLanguage,
                "manual" => AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour.Manual,
                _ => null,
            };
        }
    }
}