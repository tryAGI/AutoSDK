﻿//HintName: G.Models.AuthenticationToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Authentication Token
    /// </summary>
    public sealed partial class AuthenticationToken
    {
        /// <summary>
        /// The token used for authentication<br/>
        /// Example: v1.1f699f1069f60xxx
        /// </summary>
        /// <example>v1.1f699f1069f60xxx</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// The time this token expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public object? Permissions { get; set; }

        /// <summary>
        /// The repositories this token has access to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::G.Repository>? Repositories { get; set; }

        /// <summary>
        /// Example: config.yaml
        /// </summary>
        /// <example>config.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        public string? SingleFile { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthenticationTokenRepositorySelectionJsonConverter))]
        public global::G.AuthenticationTokenRepositorySelection? RepositorySelection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationToken" /> class.
        /// </summary>
        /// <param name="token">
        /// The token used for authentication<br/>
        /// Example: v1.1f699f1069f60xxx
        /// </param>
        /// <param name="expiresAt">
        /// The time this token expires
        /// </param>
        /// <param name="permissions"></param>
        /// <param name="repositories">
        /// The repositories this token has access to
        /// </param>
        /// <param name="singleFile">
        /// Example: config.yaml
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationToken(
            string token,
            global::System.DateTime expiresAt,
            object? permissions,
            global::System.Collections.Generic.IList<global::G.Repository>? repositories,
            string? singleFile,
            global::G.AuthenticationTokenRepositorySelection? repositorySelection)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
            this.Permissions = permissions;
            this.Repositories = repositories;
            this.SingleFile = singleFile;
            this.RepositorySelection = repositorySelection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationToken" /> class.
        /// </summary>
        public AuthenticationToken()
        {
        }
    }
}