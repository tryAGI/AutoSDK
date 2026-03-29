//HintName: G.Models.PostToolsExecuteByToolSlugInputRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugInputRequest
    {
        /// <summary>
        /// Natural language description of what you want to accomplish with this tool<br/>
        /// Example: I need to trigger the main workflow in the octocat/Hello-World repository to deploy to production
        /// </summary>
        /// <example>I need to trigger the main workflow in the octocat/Hello-World repository to deploy to production</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Custom description of the tool to help guide the LLM in generating more accurate inputs<br/>
        /// Example: This tool triggers GitHub Actions workflows in a repository. It requires the repository name, workflow ID, and optional input parameters.
        /// </summary>
        /// <example>This tool triggers GitHub Actions workflows in a repository. It requires the repository name, workflow ID, and optional input parameters.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_description")]
        public string? CustomDescription { get; set; }

        /// <summary>
        /// System prompt to control and guide the behavior of the LLM when generating inputs<br/>
        /// Example: You are an expert assistant that generates precise GitHub Actions workflow parameters. Extract exact repository names, workflow IDs, and input values from user descriptions.
        /// </summary>
        /// <example>You are an expert assistant that generates precise GitHub Actions workflow parameters. Extract exact repository names, workflow IDs, and input values from user descriptions.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Tool version to use when generating inputs (defaults to "latest" if not specified)<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugInputRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// Natural language description of what you want to accomplish with this tool<br/>
        /// Example: I need to trigger the main workflow in the octocat/Hello-World repository to deploy to production
        /// </param>
        /// <param name="customDescription">
        /// Custom description of the tool to help guide the LLM in generating more accurate inputs<br/>
        /// Example: This tool triggers GitHub Actions workflows in a repository. It requires the repository name, workflow ID, and optional input parameters.
        /// </param>
        /// <param name="systemPrompt">
        /// System prompt to control and guide the behavior of the LLM when generating inputs<br/>
        /// Example: You are an expert assistant that generates precise GitHub Actions workflow parameters. Extract exact repository names, workflow IDs, and input values from user descriptions.
        /// </param>
        /// <param name="version">
        /// Tool version to use when generating inputs (defaults to "latest" if not specified)<br/>
        /// Example: latest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteByToolSlugInputRequest(
            string text,
            string? customDescription,
            string? systemPrompt,
            string? version)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CustomDescription = customDescription;
            this.SystemPrompt = systemPrompt;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugInputRequest" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugInputRequest()
        {
        }
    }
}