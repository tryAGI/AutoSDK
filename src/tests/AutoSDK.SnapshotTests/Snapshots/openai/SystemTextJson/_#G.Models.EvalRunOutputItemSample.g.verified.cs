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
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleInputItem> Input { get; set; }

        /// <summary>
        /// An array of output messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalRunOutputItemSampleOutputItem> Output { get; set; }

        /// <summary>
        /// The reason why the sample generation was finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FinishReason { get; set; }

        /// <summary>
        /// The model used for generating the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Token usage details for the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalRunOutputItemSampleUsage Usage { get; set; }

        /// <summary>
        /// An object representing an error response from the Eval API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalApiError Error { get; set; }

        /// <summary>
        /// The sampling temperature used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Temperature { get; set; }

        /// <summary>
        /// The maximum number of tokens allowed for completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCompletionTokens { get; set; }

        /// <summary>
        /// The top_p value used for sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopP { get; set; }

        /// <summary>
        /// The seed used for generating the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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