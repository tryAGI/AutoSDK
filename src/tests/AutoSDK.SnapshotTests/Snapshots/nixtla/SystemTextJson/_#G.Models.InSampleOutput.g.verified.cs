//HintName: G.Models.InSampleOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InSampleOutput
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
        [global::System.Text.Json.Serialization.JsonPropertyName("intervals")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? Intervals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weights_x")]
        public global::System.Collections.Generic.IList<double>? WeightsX { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feature_contributions")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? FeatureContributions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InSampleOutput" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="finetuneTokens"></param>
        /// <param name="mean"></param>
        /// <param name="sizes"></param>
        /// <param name="intervals"></param>
        /// <param name="weightsX"></param>
        /// <param name="featureContributions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InSampleOutput(
            int inputTokens,
            int outputTokens,
            int finetuneTokens,
            global::System.Collections.Generic.IList<double> mean,
            global::System.Collections.Generic.IList<int> sizes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<double>>? intervals,
            global::System.Collections.Generic.IList<double>? weightsX,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? featureContributions)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.FinetuneTokens = finetuneTokens;
            this.Mean = mean ?? throw new global::System.ArgumentNullException(nameof(mean));
            this.Sizes = sizes ?? throw new global::System.ArgumentNullException(nameof(sizes));
            this.Intervals = intervals;
            this.WeightsX = weightsX;
            this.FeatureContributions = featureContributions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InSampleOutput" /> class.
        /// </summary>
        public InSampleOutput()
        {
        }
    }
}