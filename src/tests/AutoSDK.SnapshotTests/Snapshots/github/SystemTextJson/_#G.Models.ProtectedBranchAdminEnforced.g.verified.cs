﻿//HintName: G.Models.ProtectedBranchAdminEnforced.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Protected Branch Admin Enforced
    /// </summary>
    public sealed partial class ProtectedBranchAdminEnforced
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/enforce_admins
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/enforce_admins</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchAdminEnforced" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/enforce_admins
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtectedBranchAdminEnforced(
            string url,
            bool enabled)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchAdminEnforced" /> class.
        /// </summary>
        public ProtectedBranchAdminEnforced()
        {
        }
    }
}