//HintName: G.Models.GenerateSpeechResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateSpeechResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioFile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioLengthInSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioLengthInSeconds { get; set; }

        /// <summary>
        /// Number of characters consumed so far in the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumedCharacterCount")]
        public long? ConsumedCharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encodedAudio")]
        public string? EncodedAudio { get; set; }

        /// <summary>
        /// Remaining number of characters available for synthesis in the current billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingCharacterCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RemainingCharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordDurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WordDurationResponse> WordDurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechResponse" /> class.
        /// </summary>
        /// <param name="audioFile"></param>
        /// <param name="audioLengthInSeconds"></param>
        /// <param name="remainingCharacterCount">
        /// Remaining number of characters available for synthesis in the current billing cycle.
        /// </param>
        /// <param name="wordDurations"></param>
        /// <param name="consumedCharacterCount">
        /// Number of characters consumed so far in the current billing cycle.
        /// </param>
        /// <param name="encodedAudio"></param>
        /// <param name="warning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSpeechResponse(
            string audioFile,
            double audioLengthInSeconds,
            long remainingCharacterCount,
            global::System.Collections.Generic.IList<global::G.WordDurationResponse> wordDurations,
            long? consumedCharacterCount,
            string? encodedAudio,
            string? warning)
        {
            this.AudioFile = audioFile ?? throw new global::System.ArgumentNullException(nameof(audioFile));
            this.AudioLengthInSeconds = audioLengthInSeconds;
            this.ConsumedCharacterCount = consumedCharacterCount;
            this.EncodedAudio = encodedAudio;
            this.RemainingCharacterCount = remainingCharacterCount;
            this.Warning = warning;
            this.WordDurations = wordDurations ?? throw new global::System.ArgumentNullException(nameof(wordDurations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSpeechResponse" /> class.
        /// </summary>
        public GenerateSpeechResponse()
        {
        }
    }
}