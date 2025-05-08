//HintName: G.Models.EvalRunOutputItemSample.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A sample containing the input and output of the evaluation run.
    /// </summary>
    public sealed partial class EvalRunOutputItemSample
    {
        /// <summary>
        /// An array of input messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleInputItem> Input { get; set; } = default!;

        /// <summary>
        /// An array of output messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleOutputItem> Output { get; set; } = default!;

        /// <summary>
        /// The reason why the sample generation was finished.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string FinishReason { get; set; } = default!;

        /// <summary>
        /// The model used for generating the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Token usage details for the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalRunOutputItemSampleUsage Usage { get; set; } = default!;

        /// <summary>
        /// An object representing an error response from the Eval API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvalApiError Error { get; set; } = default!;

        /// <summary>
        /// The sampling temperature used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature", Required = global::Newtonsoft.Json.Required.Always)]
        public double Temperature { get; set; } = default!;

        /// <summary>
        /// The maximum number of tokens allowed for completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_completion_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxCompletionTokens { get; set; } = default!;

        /// <summary>
        /// The top_p value used for sampling.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p", Required = global::Newtonsoft.Json.Required.Always)]
        public double TopP { get; set; } = default!;

        /// <summary>
        /// The seed used for generating the sample.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSample" /> class.
        /// </summary>
        /// <param name="input">
        /// An array of input messages.
        /// </param>
        /// <param name="output">
        /// An array of output messages.
        /// </param>
        /// <param name="finishReason">
        /// The reason why the sample generation was finished.
        /// </param>
        /// <param name="model">
        /// The model used for generating the sample.
        /// </param>
        /// <param name="usage">
        /// Token usage details for the sample.
        /// </param>
        /// <param name="error">
        /// An object representing an error response from the Eval API.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature used.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of tokens allowed for completion.
        /// </param>
        /// <param name="topP">
        /// The top_p value used for sampling.
        /// </param>
        /// <param name="seed">
        /// The seed used for generating the sample.
        /// </param>
        public EvalRunOutputItemSample(
            global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleInputItem> input,
            global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleOutputItem> output,
            string finishReason,
            string model,
            global::G.EvalRunOutputItemSampleUsage usage,
            global::G.EvalApiError error,
            double temperature,
            int maxCompletionTokens,
            double topP,
            int seed)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Temperature = temperature;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.TopP = topP;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalRunOutputItemSample" /> class.
        /// </summary>
        public EvalRunOutputItemSample()
        {
        }
    }
}