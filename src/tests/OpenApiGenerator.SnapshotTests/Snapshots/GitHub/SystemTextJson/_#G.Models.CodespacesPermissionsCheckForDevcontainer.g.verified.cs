//HintName: G.Models.CodespacesPermissionsCheckForDevcontainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission check result for a given devcontainer config.
    /// </summary>
    public sealed partial class CodespacesPermissionsCheckForDevcontainer
    {
        /// <summary>
        /// Whether the user has accepted the permissions defined by the devcontainer config
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accepted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}