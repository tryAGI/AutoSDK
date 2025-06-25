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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        public string? OwnerUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPServerMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="ownerUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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