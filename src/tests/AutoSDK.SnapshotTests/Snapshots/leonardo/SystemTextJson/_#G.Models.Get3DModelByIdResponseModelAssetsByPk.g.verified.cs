//HintName: G.Models.Get3DModelByIdResponseModelAssetsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "model_assets"
    /// </summary>
    public sealed partial class Get3DModelByIdResponseModelAssetsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meshUrl")]
        public string? MeshUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelByIdResponseModelAssetsByPk" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="meshUrl"></param>
        /// <param name="name"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Get3DModelByIdResponseModelAssetsByPk(
            string? createdAt,
            string? id,
            string? meshUrl,
            string? name,
            string? updatedAt,
            string? userId)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.MeshUrl = meshUrl;
            this.Name = name;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelByIdResponseModelAssetsByPk" /> class.
        /// </summary>
        public Get3DModelByIdResponseModelAssetsByPk()
        {
        }
    }
}