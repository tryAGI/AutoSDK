//HintName: G.Models.MCPServerMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPServerMetadataResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="ownerUserId"></param>
        public MCPServerMetadataResponseModel(
            int createdAt,
            string? ownerUserId)
        {
            this.CreatedAt = createdAt;
            this.OwnerUserId = ownerUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerMetadataResponseModel" /> class.
        /// </summary>
        public MCPServerMetadataResponseModel()
        {
        }
    }
}