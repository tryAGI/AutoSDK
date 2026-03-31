//HintName: G.Models.CrossValidationOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrossValidationOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FinetuneTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Mean { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Sizes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idxs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Idxs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intervals")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Intervals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossValidationOutput" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="finetuneTokens"></param>
        /// <param name="mean"></param>
        /// <param name="sizes"></param>
        /// <param name="idxs"></param>
        /// <param name="intervals"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrossValidationOutput(
            int inputTokens,
            int outputTokens,
            int finetuneTokens,
            global::System.Collections.Generic.IList<double> mean,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.IList<int> idxs,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? intervals)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.FinetuneTokens = finetuneTokens;
            this.Mean = mean ?? throw new global::System.ArgumentNullException(nameof(mean));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
            this.Idxs = idxs ?? throw new global::System.ArgumentNullException(nameof(idxs));
            this.Intervals = intervals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrossValidationOutput" /> class.
        /// </summary>
        public CrossValidationOutput()
        {
        }
    }
}