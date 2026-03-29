//HintName: G.Models.ChecklistResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecklistResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_batch_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxBatchSize { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_base64_encoding", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SupportsBase64Encoding { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistResponse" /> class.
        /// </summary>
        /// <param name="maxBatchSize"></param>
        /// <param name="supportsBase64Encoding"></param>
        public ChecklistResponse(
            int maxBatchSize,
            bool supportsBase64Encoding)
        {
            this.MaxBatchSize = maxBatchSize;
            this.SupportsBase64Encoding = supportsBase64Encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistResponse" /> class.
        /// </summary>
        public ChecklistResponse()
        {
        }
    }
}