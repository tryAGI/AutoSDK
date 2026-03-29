//HintName: G.IAudioToTextClient.AudioToTextControllerAudioTranscription.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioToTextClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(

            global::G.AudioToTextControllerAudioTranscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="audioname"></param>
        /// <param name="audioUrl">
        /// Default Value: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        /// <param name="languageBehaviour">
        /// Default Value: automatic single language
        /// </param>
        /// <param name="language"></param>
        /// <param name="transcriptionHint"></param>
        /// <param name="toggleDiarization">
        /// Default Value: false
        /// </param>
        /// <param name="diarizationNumSpeakers"></param>
        /// <param name="diarizationMinSpeakers"></param>
        /// <param name="diarizationMaxSpeakers"></param>
        /// <param name="toggleDirectTranslate">
        /// Default Value: false
        /// </param>
        /// <param name="targetTranslationLanguage"></param>
        /// <param name="outputFormat">
        /// Default Value: json
        /// </param>
        /// <param name="toggleNoiseReduction">
        /// Default Value: false
        /// </param>
        /// <param name="toggleAccurateWordsTimestamps">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AudioToTextControllerAudioTranscriptionAsync(
            byte[]? audio = default,
            string? audioname = default,
            string? audioUrl = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviour? languageBehaviour = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestLanguage? language = default,
            string? transcriptionHint = default,
            bool? toggleDiarization = default,
            int? diarizationNumSpeakers = default,
            int? diarizationMinSpeakers = default,
            int? diarizationMaxSpeakers = default,
            bool? toggleDirectTranslate = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguage? targetTranslationLanguage = default,
            global::G.AudioToTextControllerAudioTranscriptionRequestOutputFormat? outputFormat = default,
            bool? toggleNoiseReduction = default,
            bool? toggleAccurateWordsTimestamps = default,
            string? webhookUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}