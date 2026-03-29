//HintName: G.Models.PostOrgOwnerProjectNewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewRequest
    {
        /// <summary>
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </summary>
        /// <example>my-awesome-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_create_api_key")]
        public bool? ShouldCreateApiKey { get; set; }

        /// <summary>
        /// Configuration for the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.PostOrgOwnerProjectNewRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </param>
        /// <param name="shouldCreateApiKey">
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="config">
        /// Configuration for the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectNewRequest(
            string name,
            bool? shouldCreateApiKey,
            global::G.PostOrgOwnerProjectNewRequestConfig? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ShouldCreateApiKey = shouldCreateApiKey;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequest" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewRequest()
        {
        }
    }
}