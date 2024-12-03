//HintName: G.Models.UserExtensionOverlayUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserExtensionOverlayUpdate
    {
        /// <summary>
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured an overlay extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Active { get; set; } = default!;

        /// <summary>
        /// An ID that identifies the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The extension’s version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionOverlayUpdate" /> class.
        /// </summary>
        /// <param name="active">
        /// A Boolean value that determines the extension’s activation state. If **false**, the user has not configured an overlay extension.
        /// </param>
        /// <param name="id">
        /// An ID that identifies the extension.
        /// </param>
        /// <param name="version">
        /// The extension’s version.
        /// </param>
        public UserExtensionOverlayUpdate(
            bool active,
            string? id,
            string? version)
        {
            this.Active = active;
            this.Id = id;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserExtensionOverlayUpdate" /> class.
        /// </summary>
        public UserExtensionOverlayUpdate()
        {
        }
    }
}