//HintName: G.Models.ChatCompletionMessageExecutedTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageExecutedTool
    {
        /// <summary>
        /// The index of the executed tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The type of tool that was executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The arguments passed to the tool in JSON format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// The output returned by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// The search results returned by the tool, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        public global::G.ChatCompletionMessageExecutedToolSearchResults? SearchResults { get; set; }

        /// <summary>
        /// Array of code execution results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_results")]
        public global::System.Collections.Generic.IList<global::G.CodeExecutionResult>? CodeResults { get; set; }

        /// <summary>
        /// Array of browser results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browser_results")]
        public global::System.Collections.Generic.IList<global::G.BrowserResult>? BrowserResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedTool" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the executed tool.
        /// </param>
        /// <param name="type">
        /// The type of tool that was executed.
        /// </param>
        /// <param name="arguments">
        /// The arguments passed to the tool in JSON format.
        /// </param>
        /// <param name="output">
        /// The output returned by the tool.
        /// </param>
        /// <param name="searchResults">
        /// The search results returned by the tool, if applicable.
        /// </param>
        /// <param name="codeResults">
        /// Array of code execution results
        /// </param>
        /// <param name="browserResults">
        /// Array of browser results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageExecutedTool(
            int index,
            string type,
            string arguments,
            string? output,
            global::G.ChatCompletionMessageExecutedToolSearchResults? searchResults,
            global::System.Collections.Generic.IList<global::G.CodeExecutionResult>? codeResults,
            global::System.Collections.Generic.IList<global::G.BrowserResult>? browserResults)
        {
            this.Index = index;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Output = output;
            this.SearchResults = searchResults;
            this.CodeResults = codeResults;
            this.BrowserResults = browserResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedTool" /> class.
        /// </summary>
        public ChatCompletionMessageExecutedTool()
        {
        }
    }
}