//HintName: G.Models.ModelSpendPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelSpendPricing
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWritePer1M")]
        public double? CacheWritePer1M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheReadPer1M")]
        public double? CacheReadPer1M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputPer1M")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputPer1M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputPer1M")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputPer1M { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpendPricing" /> class.
        /// </summary>
        /// <param name="outputPer1M"></param>
        /// <param name="inputPer1M"></param>
        /// <param name="cacheWritePer1M"></param>
        /// <param name="cacheReadPer1M"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelSpendPricing(
            double outputPer1M,
            double inputPer1M,
            double? cacheWritePer1M,
            double? cacheReadPer1M)
        {
            this.CacheWritePer1M = cacheWritePer1M;
            this.CacheReadPer1M = cacheReadPer1M;
            this.OutputPer1M = outputPer1M;
            this.InputPer1M = inputPer1M;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpendPricing" /> class.
        /// </summary>
        public ModelSpendPricing()
        {
        }
    }
}