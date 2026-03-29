//HintName: G.Models.PostOrgOwnerProjectNewResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewResponse
    {
        /// <summary>
        /// Unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </summary>
        /// <example>proj_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </summary>
        /// <example>My Awesome Project</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API key for the project<br/>
        /// Example: ak_abc123xyz456
        /// </summary>
        /// <example>ak_abc123xyz456</example>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </param>
        /// <param name="apiKey">
        /// API key for the project<br/>
        /// Example: ak_abc123xyz456
        /// </param>
        public PostOrgOwnerProjectNewResponse(
            string id,
            string? name,
            string? apiKey)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewResponse" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewResponse()
        {
        }
    }
}