//HintName: G.Models.SecretReferenceDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretReferenceDetailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organisation_id")]
        public global::System.Guid? OrganisationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public global::G.SecretReferenceDetailResponseManagerType? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_path")]
        public string? SecretPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_key")]
        public string? SecretKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allow_all_workspaces")]
        public bool? AllowAllWorkspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.SecretReferenceDetailResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Sensitive fields are masked for non-system users
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_config")]
        public object? AuthConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.SecretReferenceDetailResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretReferenceDetailResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organisationId"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="description"></param>
        /// <param name="managerType"></param>
        /// <param name="secretPath"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces"></param>
        /// <param name="tags"></param>
        /// <param name="status"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="authConfig">
        /// Sensitive fields are masked for non-system users
        /// </param>
        /// <param name="object"></param>
        public SecretReferenceDetailResponse(
            global::System.Guid? id,
            global::System.Guid? organisationId,
            string? name,
            string? slug,
            string? description,
            global::G.SecretReferenceDetailResponseManagerType? managerType,
            string? secretPath,
            string? secretKey,
            bool? allowAllWorkspaces,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::G.SecretReferenceDetailResponseStatus? status,
            string? createdBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? lastUpdatedAt,
            object? authConfig,
            global::G.SecretReferenceDetailResponseObject? @object)
        {
            this.Id = id;
            this.OrganisationId = organisationId;
            this.Name = name;
            this.Slug = slug;
            this.Description = description;
            this.ManagerType = managerType;
            this.SecretPath = secretPath;
            this.SecretKey = secretKey;
            this.AllowAllWorkspaces = allowAllWorkspaces;
            this.Tags = tags;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.AuthConfig = authConfig;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretReferenceDetailResponse" /> class.
        /// </summary>
        public SecretReferenceDetailResponse()
        {
        }
    }
}