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
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProjectServiceAccountApiKey ApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectServiceAccountCreateResponseObject Object { get; set; }

        /// <summary>
        /// Service accounts can only have one role of type `member`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ProjectServiceAccountCreateResponseRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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