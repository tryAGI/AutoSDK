//HintName: G.Models.AuditLogApiKeyUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the API key.
    /// </summary>
    public sealed partial class AuditLogApiKeyUpdatedChangesRequested
    {
        /// <summary>
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="scopes">
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuditLogApiKeyUpdatedChangesRequested(
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogApiKeyUpdatedChangesRequested()
        {
        }
    }
}