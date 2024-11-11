//HintName: G.Models.GetTextureGenerationsByModelIdRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTextureGenerationsByModelIdRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdRequest" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="modelId"></param>
        /// <param name="offset"></param>
        public GetTextureGenerationsByModelIdRequest(
            int? limit,
            string? modelId,
            int? offset)
        {
            this.Limit = limit;
            this.ModelId = modelId;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdRequest" /> class.
        /// </summary>
        public GetTextureGenerationsByModelIdRequest()
        {
        }
    }
}