//HintName: G.Models.Get3DModelsByUserIdResponseModelAsset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "model_assets"
    /// </summary>
    public sealed partial class Get3DModelsByUserIdResponseModelAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meshUrl")]
        public string? MeshUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdResponseModelAsset" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="meshUrl"></param>
        /// <param name="name"></param>
        /// <param name="updatedAt"></param>
        /// <param name="userId"></param>
        public Get3DModelsByUserIdResponseModelAsset(
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
        /// Initializes a new instance of the <see cref="Get3DModelsByUserIdResponseModelAsset" /> class.
        /// </summary>
        public Get3DModelsByUserIdResponseModelAsset()
        {
        }
    }
}