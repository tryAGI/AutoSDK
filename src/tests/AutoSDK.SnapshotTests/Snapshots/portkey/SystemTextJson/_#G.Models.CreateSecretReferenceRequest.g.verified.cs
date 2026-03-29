//HintName: G.Models.CreateSecretReferenceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSecretReferenceRequest
    {
        /// <summary>
        /// Required if not using API key auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Auto-generated from name if omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateSecretReferenceRequestManagerTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateSecretReferenceRequestManagerType ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// Cannot be true when allowed_workspaces is provided<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_workspaces")]
        public bool? AllowAllWorkspaces { get; set; }

        /// <summary>
        /// Array of workspace UUIDs or slugs. Mutually exclusive with allow_all_workspaces=true.
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
        /// Initializes a new instance of the <see cref="CreateSecretReferenceRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="managerType"></param>
        /// <param name="authConfig"></param>
        /// <param name="secretPath"></param>
        /// <param name="organisationId">
        /// Required if not using API key auth
        /// </param>
        /// <param name="slug">
        /// Auto-generated from name if omitted
        /// </param>
        /// <param name="description"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces">
        /// Cannot be true when allowed_workspaces is provided<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowedWorkspaces">
        /// Array of workspace UUIDs or slugs. Mutually exclusive with allow_all_workspaces=true.
        /// </param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSecretReferenceRequest(
            string name,
            global::G.CreateSecretReferenceRequestManagerType managerType,
            global::G.AuthConfig authConfig,
            string secretPath,
            global::System.Guid? organisationId,
            string? slug,
            string? description,
            string? secretKey,
            bool? allowAllWorkspaces,
            global::System.Collections.Generic.IList<string>? allowedWorkspaces,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.OrganisationId = organisationId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug;
            this.Description = description;
            this.ManagerType = managerType;
            this.AuthConfig = authConfig;
            this.SecretPath = secretPath ?? throw new global::System.ArgumentNullException(nameof(secretPath));
            this.SecretKey = secretKey;
            this.AllowAllWorkspaces = allowAllWorkspaces;
            this.AllowedWorkspaces = allowedWorkspaces;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecretReferenceRequest" /> class.
        /// </summary>
        public CreateSecretReferenceRequest()
        {
        }
    }
}