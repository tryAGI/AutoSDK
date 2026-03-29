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
        [global::Newtonsoft.Json.JsonProperty("cacheWritePer1M")]
        public double? CacheWritePer1M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheReadPer1M")]
        public double? CacheReadPer1M { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputPer1M", Required = global::Newtonsoft.Json.Required.Always)]
        public double OutputPer1M { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputPer1M", Required = global::Newtonsoft.Json.Required.Always)]
        public double InputPer1M { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpendPricing" /> class.
        /// </summary>
        /// <param name="outputPer1M"></param>
        /// <param name="inputPer1M"></param>
        /// <param name="cacheWritePer1M"></param>
        /// <param name="cacheReadPer1M"></param>
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