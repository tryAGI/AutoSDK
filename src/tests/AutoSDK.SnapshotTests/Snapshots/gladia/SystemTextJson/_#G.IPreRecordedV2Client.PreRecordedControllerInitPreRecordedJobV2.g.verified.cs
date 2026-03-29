//HintName: G.IPreRecordedV2Client.PreRecordedControllerInitPreRecordedJobV2.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IPreRecordedV2Client
    {
        /// <summary>
        /// Initiate a new pre recorded job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitPreRecordedTranscriptionResponse> PreRecordedControllerInitPreRecordedJobV2Async(

            global::G.InitTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a new pre recorded job
        /// </summary>
        /// <param name="customVocabulary">
        /// **[Beta]** Can be either boolean to enable custom_vocabulary for this audio or an array with specific vocabulary list to feed the transcription model with<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customVocabularyConfig">
        /// **[Beta]** Custom vocabulary configuration, if `custom_vocabulary` is enabled
        /// </param>
        /// <param name="callback">
        /// Enable callback for this transcription. If true, the `callback_config` property will be used to customize the callback behaviour<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Customize the callback behaviour (url and http method)
        /// </param>
        /// <param name="subtitles">
        /// Enable subtitles generation for this transcription<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subtitlesConfig">
        /// Configuration for subtitles generation if `subtitles` is enabled
        /// </param>
        /// <param name="diarization">
        /// Enable speaker recognition (diarization) for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="diarizationConfig">
        /// Speaker recognition configuration, if `diarization` is enabled
        /// </param>
        /// <param name="translation">
        /// **[Beta]** Enable translation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="translationConfig">
        /// **[Beta]** Translation configuration, if `translation` is enabled
        /// </param>
        /// <param name="summarization">
        /// **[Beta]** Enable summarization for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summarizationConfig">
        /// **[Beta]** Summarization configuration, if `summarization` is enabled
        /// </param>
        /// <param name="namedEntityRecognition">
        /// **[Alpha]** Enable named entity recognition for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpelling">
        /// **[Alpha]** Enable custom spelling for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpellingConfig">
        /// **[Alpha]** Custom spelling configuration, if `custom_spelling` is enabled
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable sentiment analysis for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlm">
        /// **[Alpha]** Enable audio to llm processing for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioToLlmConfig">
        /// **[Alpha]** Audio to llm configuration, if `audio_to_llm` is enabled
        /// </param>
        /// <param name="piiRedaction">
        /// Enable PII redaction for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="piiRedactionConfig">
        /// PII redaction configuration, if `pii_redaction` is enabled
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="sentences">
        /// Enable sentences for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="punctuationEnhanced">
        /// **[Alpha]** Use enhanced punctuation for this audio<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="audioUrl">
        /// URL to a Gladia file or to an external audio or video file<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitPreRecordedTranscriptionResponse> PreRecordedControllerInitPreRecordedJobV2Async(
            string audioUrl,
            bool? customVocabulary = default,
            global::G.CustomVocabularyConfigDTO? customVocabularyConfig = default,
            bool? callback = default,
            global::G.CallbackConfigDto? callbackConfig = default,
            bool? subtitles = default,
            global::G.SubtitlesConfigDTO? subtitlesConfig = default,
            bool? diarization = default,
            global::G.DiarizationConfigDTO? diarizationConfig = default,
            bool? translation = default,
            global::G.TranslationConfigDTO? translationConfig = default,
            bool? summarization = default,
            global::G.SummarizationConfigDTO? summarizationConfig = default,
            bool? namedEntityRecognition = default,
            bool? customSpelling = default,
            global::G.CustomSpellingConfigDTO? customSpellingConfig = default,
            bool? sentimentAnalysis = default,
            bool? audioToLlm = default,
            global::G.AudioToLlmListConfigDTO? audioToLlmConfig = default,
            bool? piiRedaction = default,
            global::G.PiiRedactionConfigDTO? piiRedactionConfig = default,
            object? customMetadata = default,
            bool? sentences = default,
            bool? punctuationEnhanced = default,
            global::G.LanguageConfig? languageConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}