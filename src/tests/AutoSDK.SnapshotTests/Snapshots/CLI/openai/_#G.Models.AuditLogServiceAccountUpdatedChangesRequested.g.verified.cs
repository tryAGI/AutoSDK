﻿//HintName: G.Models.AuditLogServiceAccountUpdatedChangesRequested.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The payload used to updated the service account.
    /// </summary>
    public sealed partial class AuditLogServiceAccountUpdatedChangesRequested
    {
        /// <summary>
        /// The role of the service account. Is either `owner` or `member`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the service account. Is either `owner` or `member`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogServiceAccountUpdatedChangesRequested(
            string? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogServiceAccountUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogServiceAccountUpdatedChangesRequested()
        {
        }
    }
}