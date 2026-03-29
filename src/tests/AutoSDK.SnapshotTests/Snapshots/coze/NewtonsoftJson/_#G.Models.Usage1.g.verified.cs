//HintName: G.Models.Usage1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage1
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
        /// Initializes a new instance of the <see cref="Usage1" /> class.
        /// </summary>
        /// <param name="inputCount"></param>
        /// <param name="outputCount"></param>
        /// <param name="tokenCount"></param>
        public Usage1(
            int? inputCount,
            int? outputCount,
            int? tokenCount)
        {
            this.InputCount = inputCount;
            this.OutputCount = outputCount;
            this.TokenCount = tokenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage1" /> class.
        /// </summary>
        public Usage1()
        {
        }
    }
}