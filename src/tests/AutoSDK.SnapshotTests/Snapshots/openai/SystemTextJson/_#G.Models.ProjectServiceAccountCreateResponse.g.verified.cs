//HintName: G.Models.ProjectServiceAccountCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectServiceAccountCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProjectServiceAccountApiKey ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectServiceAccountCreateResponseObjectJsonConverter))]
        public global::G.ProjectServiceAccountCreateResponseObject Object { get; set; }

        /// <summary>
        /// Service accounts can only have one role of type `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectServiceAccountCreateResponseRoleJsonConverter))]
        public global::G.ProjectServiceAccountCreateResponseRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateResponse" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="object"></param>
        /// <param name="role">
        /// Service accounts can only have one role of type `member`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectServiceAccountCreateResponse(
            global::G.ProjectServiceAccountApiKey apiKey,
            int createdAt,
            string id,
            string name,
            global::G.ProjectServiceAccountCreateResponseObject @object,
            global::G.ProjectServiceAccountCreateResponseRole role)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Object = @object;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateResponse" /> class.
        /// </summary>
        public ProjectServiceAccountCreateResponse()
        {
        }
    }
}