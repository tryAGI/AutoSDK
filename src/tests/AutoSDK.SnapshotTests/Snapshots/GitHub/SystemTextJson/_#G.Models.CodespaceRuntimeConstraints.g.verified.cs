//HintName: G.Models.CodespaceRuntimeConstraints.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespaceRuntimeConstraints
    {
        /// <summary>
        /// The privacy settings a user can select from when forwarding a port.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_port_privacy_settings")]
        public global::System.Collections.Generic.IList<string>? AllowedPortPrivacySettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceRuntimeConstraints" /> class.
        /// </summary>
        /// <param name="allowedPortPrivacySettings">
        /// The privacy settings a user can select from when forwarding a port.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespaceRuntimeConstraints(
            global::System.Collections.Generic.IList<string>? allowedPortPrivacySettings)
        {
            this.AllowedPortPrivacySettings = allowedPortPrivacySettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespaceRuntimeConstraints" /> class.
        /// </summary>
        public CodespaceRuntimeConstraints()
        {
        }
    }
}