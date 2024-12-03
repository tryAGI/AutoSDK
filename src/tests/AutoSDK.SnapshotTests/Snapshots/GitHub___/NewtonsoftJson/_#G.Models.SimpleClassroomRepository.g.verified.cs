//HintName: G.Models.SimpleClassroomRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub repository view for Classroom
    /// </summary>
    public sealed partial class SimpleClassroomRepository
    {
        /// <summary>
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269
        /// </summary>
        /// <example>1296269</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The full, globally unique name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </summary>
        /// <example>octocat/Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("full_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FullName { get; set; } = default!;

        /// <summary>
        /// The URL to view the repository on GitHub.com.<br/>
        /// Example: https://github.com/octocat/Hello-World
        /// </summary>
        /// <example>https://github.com/octocat/Hello-World</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </summary>
        /// <example>MDEwOlJlcG9zaXRvcnkxMjk2MjY5</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Whether the repository is private.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("private", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Private { get; set; } = default!;

        /// <summary>
        /// The default branch for the repository.<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::Newtonsoft.Json.JsonProperty("default_branch", Required = global::Newtonsoft.Json.Required.Always)]
        public string DefaultBranch { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomRepository" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the repository.<br/>
        /// Example: 1296269
        /// </param>
        /// <param name="fullName">
        /// The full, globally unique name of the repository.<br/>
        /// Example: octocat/Hello-World
        /// </param>
        /// <param name="htmlUrl">
        /// The URL to view the repository on GitHub.com.<br/>
        /// Example: https://github.com/octocat/Hello-World
        /// </param>
        /// <param name="nodeId">
        /// The GraphQL identifier of the repository.<br/>
        /// Example: MDEwOlJlcG9zaXRvcnkxMjk2MjY5
        /// </param>
        /// <param name="private">
        /// Whether the repository is private.
        /// </param>
        /// <param name="defaultBranch">
        /// The default branch for the repository.<br/>
        /// Example: main
        /// </param>
        public SimpleClassroomRepository(
            int id,
            string fullName,
            string htmlUrl,
            string nodeId,
            bool @private,
            string defaultBranch)
        {
            this.Id = id;
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Private = @private;
            this.DefaultBranch = defaultBranch ?? throw new global::System.ArgumentNullException(nameof(defaultBranch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleClassroomRepository" /> class.
        /// </summary>
        public SimpleClassroomRepository()
        {
        }
    }
}