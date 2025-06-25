//HintName: G.Models.AuditLogUserUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to update the user.
    /// </summary>
    public sealed partial class AuditLogUserUpdatedChangesRequested
    {
        /// <summary>
        /// The role of the user. Is either `owner` or `member`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the user. Is either `owner` or `member`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogUserUpdatedChangesRequested(
            string? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogUserUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogUserUpdatedChangesRequested()
        {
        }
    }
}