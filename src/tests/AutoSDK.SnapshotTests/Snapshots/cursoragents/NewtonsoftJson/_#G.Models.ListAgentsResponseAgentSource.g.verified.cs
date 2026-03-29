//HintName: G.Models.ListAgentsResponseAgentSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsResponseAgentSource
    {
        /// <summary>
        /// The GitHub repository URL<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// Git ref (branch/tag) used as the base branch<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponseAgentSource" /> class.
        /// </summary>
        /// <param name="repository">
        /// The GitHub repository URL<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        /// <param name="ref">
        /// Git ref (branch/tag) used as the base branch<br/>
        /// Example: main
        /// </param>
        public ListAgentsResponseAgentSource(
            string? repository,
            string? @ref)
        {
            this.Repository = repository;
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponseAgentSource" /> class.
        /// </summary>
        public ListAgentsResponseAgentSource()
        {
        }
    }
}