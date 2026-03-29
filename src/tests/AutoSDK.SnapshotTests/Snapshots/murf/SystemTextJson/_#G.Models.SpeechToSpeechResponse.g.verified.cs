//HintName: G.Models.SpeechToSpeechResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpeechToSpeechResponse
    {
        /// <summary>
        /// The URL or path of the generated audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFile { get; set; }

        /// <summary>
        /// Length of the generated audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_length_in_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioLengthInSeconds { get; set; }

        /// <summary>
        /// Base64 encoded string of the generated audio. Used when audio is returned directly in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_audio")]
        public string? EncodedAudio { get; set; }

        /// <summary>
        /// Remaining number of characters available for synthesis in the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RemainingCharacterCount { get; set; }

        /// <summary>
        /// Transcript of the generated audio, if transcription was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// Any warning or informational message related to the audio generation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToSpeechResponse" /> class.
        /// </summary>
        /// <param name="audioFile">
        /// The URL or path of the generated audio file.
        /// </param>
        /// <param name="audioLengthInSeconds">
        /// Length of the generated audio in seconds.
        /// </param>
        /// <param name="remainingCharacterCount">
        /// Remaining number of characters available for synthesis in the current billing cycle.
        /// </param>
        /// <param name="encodedAudio">
        /// Base64 encoded string of the generated audio. Used when audio is returned directly in the response.
        /// </param>
        /// <param name="transcription">
        /// Transcript of the generated audio, if transcription was requested.
        /// </param>
        /// <param name="warning">
        /// Any warning or informational message related to the audio generation process.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToSpeechResponse(
            string audioFile,
            double audioLengthInSeconds,
            long remainingCharacterCount,
            string? encodedAudio,
            string? transcription,
            string? warning)
        {
            this.AudioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            this.AudioLengthInSeconds = audioLengthInSeconds;
            this.EncodedAudio = encodedAudio;
            this.RemainingCharacterCount = remainingCharacterCount;
            this.Transcription = transcription;
            this.Warning = warning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToSpeechResponse" /> class.
        /// </summary>
        public SpeechToSpeechResponse()
        {
        }
    }
}