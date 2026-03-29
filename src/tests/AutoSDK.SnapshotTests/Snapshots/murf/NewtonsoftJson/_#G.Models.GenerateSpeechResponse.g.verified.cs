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
        [global::Newtonsoft.Json.JsonProperty("audioFile", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audioLengthInSeconds", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioLengthInSeconds { get; set; } = default!;

        /// <summary>
        /// Number of characters consumed so far in the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consumedCharacterCount")]
        public long? ConsumedCharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encodedAudio")]
        public string? EncodedAudio { get; set; }

        /// <summary>
        /// Remaining number of characters available for synthesis in the current billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remainingCharacterCount", Required = global::Newtonsoft.Json.Required.Always)]
        public long RemainingCharacterCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordDurations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WordDurationResponse> WordDurations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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