//HintName: G.Models.CreateAgentRequestSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequestSource
    {
        /// <summary>
        /// The GitHub repository URL. Required unless prUrl is provided.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// Git ref (branch/tag) to use as the base branch<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// GitHub pull request URL. When provided, the agent works on this PR's repository and branches. Mutually exclusive with repository/ref.<br/>
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </summary>
        /// <example>https://github.com/your-org/your-repo/pull/123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prUrl")]
        public string? PrUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestSource" /> class.
        /// </summary>
        /// <param name="repository">
        /// The GitHub repository URL. Required unless prUrl is provided.<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        /// <param name="ref">
        /// Git ref (branch/tag) to use as the base branch<br/>
        /// Example: main
        /// </param>
        /// <param name="prUrl">
        /// GitHub pull request URL. When provided, the agent works on this PR's repository and branches. Mutually exclusive with repository/ref.<br/>
        /// Example: https://github.com/your-org/your-repo/pull/123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequestSource(
            string? repository,
            string? @ref,
            string? prUrl)
        {
            this.Repository = repository;
            this.Ref = @ref;
            this.PrUrl = prUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequestSource" /> class.
        /// </summary>
        public CreateAgentRequestSource()
        {
        }
    }
}