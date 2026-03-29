//HintName: G.Models.GetAgentResponseSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentResponseSource
    {
        /// <summary>
        /// The GitHub repository URL<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </summary>
        /// <example>https://github.com/your-org/your-repo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// Git ref (branch/tag) used as the base branch<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseSource" /> class.
        /// </summary>
        /// <param name="repository">
        /// The GitHub repository URL<br/>
        /// Example: https://github.com/your-org/your-repo
        /// </param>
        /// <param name="ref">
        /// Git ref (branch/tag) used as the base branch<br/>
        /// Example: main
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentResponseSource(
            string? repository,
            string? @ref)
        {
            this.Repository = repository;
            this.Ref = @ref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentResponseSource" /> class.
        /// </summary>
        public GetAgentResponseSource()
        {
        }
    }
}