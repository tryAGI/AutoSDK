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
        /// Whether the user has accepted the permissions defined by the devcontainer config<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Accepted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPermissionsCheckForDevcontainer" /> class.
        /// </summary>
        /// <param name="accepted">
        /// Whether the user has accepted the permissions defined by the devcontainer config<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesPermissionsCheckForDevcontainer(
            bool accepted)
        {
            this.Accepted = accepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPermissionsCheckForDevcontainer" /> class.
        /// </summary>
        public CodespacesPermissionsCheckForDevcontainer()
        {
        }
    }
}