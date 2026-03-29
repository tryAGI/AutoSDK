//HintName: G.Models.CompletionsChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionsChoice
    {
        /// <summary>
        /// The generated text output from the model, which forms the main content of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_probs")]
        public global::G.Logprobs? LogProbs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsChoice" /> class.
        /// </summary>
        /// <param name="text">
        /// The generated text output from the model, which forms the main content of the response.
        /// </param>
        /// <param name="logProbs"></param>
        public CompletionsChoice(
            string text,
            global::G.Logprobs? logProbs)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.LogProbs = logProbs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsChoice" /> class.
        /// </summary>
        public CompletionsChoice()
        {
        }
    }
}