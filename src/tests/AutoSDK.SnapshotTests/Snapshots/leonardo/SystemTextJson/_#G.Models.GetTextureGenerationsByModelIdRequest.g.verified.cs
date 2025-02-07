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
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTextureGenerationsByModelIdRequest" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="modelId"></param>
        /// <param name="offset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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