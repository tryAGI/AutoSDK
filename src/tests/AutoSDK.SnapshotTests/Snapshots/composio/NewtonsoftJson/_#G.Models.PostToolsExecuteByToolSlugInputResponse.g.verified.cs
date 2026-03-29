//HintName: G.Models.PostToolsExecuteByToolSlugInputResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugInputResponse
    {
        /// <summary>
        /// Key-value pairs of arguments required by the tool to accomplish the described task<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </summary>
        /// <example>{"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}</example>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Arguments { get; set; }

        /// <summary>
        /// Error message if the arguments could not be generated (null if successful)<br/>
        /// Example: Unable to determine the repository name from the provided description
        /// </summary>
        /// <example>Unable to determine the repository name from the provided description</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugInputResponse" /> class.
        /// </summary>
        /// <param name="arguments">
        /// Key-value pairs of arguments required by the tool to accomplish the described task<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="error">
        /// Error message if the arguments could not be generated (null if successful)<br/>
        /// Example: Unable to determine the repository name from the provided description
        /// </param>
        public PostToolsExecuteByToolSlugInputResponse(
            global::System.Collections.Generic.Dictionary<string, object?>? arguments,
            string? error)
        {
            this.Arguments = arguments;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugInputResponse" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugInputResponse()
        {
        }
    }
}