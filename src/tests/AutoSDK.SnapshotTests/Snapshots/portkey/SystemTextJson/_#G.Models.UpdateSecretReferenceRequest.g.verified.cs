//HintName: G.Models.UpdateSecretReferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSecretReferenceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Merged with existing config, validated against existing manager_type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        public object? AuthConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_path")]
        public string? SecretPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// When true, all workspace-specific mappings are purged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_workspaces")]
        public bool? AllowAllWorkspaces { get; set; }

        /// <summary>
        /// Replaces existing workspace mappings. Automatically sets allow_all_workspaces to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_workspaces")]
        public global::System.Collections.Generic.IList<string>? AllowedWorkspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretReferenceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authConfig">
        /// Merged with existing config, validated against existing manager_type
        /// </param>
        /// <param name="secretPath"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces">
        /// When true, all workspace-specific mappings are purged
        /// </param>
        /// <param name="allowedWorkspaces">
        /// Replaces existing workspace mappings. Automatically sets allow_all_workspaces to false.
        /// </param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSecretReferenceRequest(
            string? name,
            string? description,
            object? authConfig,
            string? secretPath,
            string? secretKey,
            bool? allowAllWorkspaces,
            global::System.Collections.Generic.IList<string>? allowedWorkspaces,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.Name = name;
            this.Description = description;
            this.AuthConfig = authConfig;
            this.SecretPath = secretPath;
            this.SecretKey = secretKey;
            this.AllowAllWorkspaces = allowAllWorkspaces;
            this.AllowedWorkspaces = allowedWorkspaces;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSecretReferenceRequest" /> class.
        /// </summary>
        public UpdateSecretReferenceRequest()
        {
        }
    }
}