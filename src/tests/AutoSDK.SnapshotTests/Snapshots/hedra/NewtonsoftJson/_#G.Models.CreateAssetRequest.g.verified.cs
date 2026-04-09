//HintName: G.Models.CreateAssetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetRequest
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AssetTypeJsonConverter))]
        public global::G.AssetType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="workspaceId"></param>
        public CreateAssetRequest(
            string name,
            global::G.AssetType type,
            string? workspaceId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetRequest" /> class.
        /// </summary>
        public CreateAssetRequest()
        {
        }
    }
}