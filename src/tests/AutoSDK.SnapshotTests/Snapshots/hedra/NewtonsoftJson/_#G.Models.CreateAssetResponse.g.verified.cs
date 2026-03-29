//HintName: G.Models.CreateAssetResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetResponse
    {
        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AssetType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// The id of the newly created asset. Should be used for upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Presigned S3 URL for uploading the asset file using HTTP PUT. Only present when the asset type is VIDEO.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upload_url")]
        public string? UploadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="id">
        /// The id of the newly created asset. Should be used for upload.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="uploadUrl">
        /// Presigned S3 URL for uploading the asset file using HTTP PUT. Only present when the asset type is VIDEO.
        /// </param>
        public CreateAssetResponse(
            string name,
            global::G.AssetType type,
            global::System.Guid id,
            string? workspaceId,
            string? uploadUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.WorkspaceId = workspaceId;
            this.Id = id;
            this.UploadUrl = uploadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetResponse" /> class.
        /// </summary>
        public CreateAssetResponse()
        {
        }
    }
}