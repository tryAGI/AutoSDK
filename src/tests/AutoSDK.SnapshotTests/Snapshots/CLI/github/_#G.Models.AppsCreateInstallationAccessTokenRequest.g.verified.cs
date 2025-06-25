﻿//HintName: G.Models.AppsCreateInstallationAccessTokenRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppsCreateInstallationAccessTokenRequest
    {
        /// <summary>
        /// List of repository names that the token should have access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// List of repository IDs that the token should have access to<br/>
        /// Example: [1]
        /// </summary>
        /// <example>[1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids")]
        public global::System.Collections.Generic.IList<int>? RepositoryIds { get; set; }

        /// <summary>
        /// The permissions granted to the user access token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::G.AppPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateInstallationAccessTokenRequest" /> class.
        /// </summary>
        /// <param name="repositories">
        /// List of repository names that the token should have access to
        /// </param>
        /// <param name="repositoryIds">
        /// List of repository IDs that the token should have access to<br/>
        /// Example: [1]
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsCreateInstallationAccessTokenRequest(
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<int>? repositoryIds,
            global::G.AppPermissions? permissions)
        {
            this.Repositories = repositories;
            this.RepositoryIds = repositoryIds;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsCreateInstallationAccessTokenRequest" /> class.
        /// </summary>
        public AppsCreateInstallationAccessTokenRequest()
        {
        }
    }
}