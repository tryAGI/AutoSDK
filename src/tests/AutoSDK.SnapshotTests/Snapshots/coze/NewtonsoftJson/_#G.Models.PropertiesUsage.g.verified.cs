//HintName: G.Models.PropertiesUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 资源使用情况
    /// </summary>
    public sealed partial class PropertiesUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_count")]
        public int? InputCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_count")]
        public int? OutputCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_count")]
        public int? TokenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesUsage" /> class.
        /// </summary>
        /// <param name="inputCount"></param>
        /// <param name="outputCount"></param>
        /// <param name="tokenCount"></param>
        public PropertiesUsage(
            int? inputCount,
            int? outputCount,
            int? tokenCount)
        {
            this.InputCount = inputCount;
            this.OutputCount = outputCount;
            this.TokenCount = tokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesUsage" /> class.
        /// </summary>
        public PropertiesUsage()
        {
        }
    }
}