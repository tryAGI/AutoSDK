//HintName: G.Models.CreateTranscriptionResponseJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a transcription response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateTranscriptionResponseJson
    {
        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The log probabilities of the tokens in the transcription. Only returned with the models `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` if `logprobs` is added to the `include` array.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<global::G.CreateTranscriptionResponseJsonLogprob>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJson" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the tokens in the transcription. Only returned with the models `gpt-4o-transcribe` and `gpt-4o-mini-transcribe` if `logprobs` is added to the `include` array.
        /// </param>
        public CreateTranscriptionResponseJson(
            string text,
            global::System.Collections.Generic.IList<global::G.CreateTranscriptionResponseJsonLogprob>? logprobs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseJson" /> class.
        /// </summary>
        public CreateTranscriptionResponseJson()
        {
        }
    }
}