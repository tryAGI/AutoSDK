//HintName: G.Models.GetSnippetUsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSnippetUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The name of the snippet prompt template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet_name")]
        public string? SnippetName { get; set; }

        /// <summary>
        /// List of prompts using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet_usage")]
        public global::System.Collections.Generic.IList<global::G.GetSnippetUsageResponseSnippetUsageItem>? SnippetUsage { get; set; }

        /// <summary>
        /// Total number of prompts using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompts_using_snippet")]
        public int? TotalPromptsUsingSnippet { get; set; }

        /// <summary>
        /// List of labels using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_usage")]
        public global::System.Collections.Generic.IList<global::G.GetSnippetUsageResponseLabelUsageItem>? LabelUsage { get; set; }

        /// <summary>
        /// Total number of labels using this snippet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_labels_using_snippet")]
        public int? TotalLabelsUsingSnippet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="snippetName">
        /// The name of the snippet prompt template
        /// </param>
        /// <param name="snippetUsage">
        /// List of prompts using this snippet
        /// </param>
        /// <param name="totalPromptsUsingSnippet">
        /// Total number of prompts using this snippet
        /// </param>
        /// <param name="labelUsage">
        /// List of labels using this snippet
        /// </param>
        /// <param name="totalLabelsUsingSnippet">
        /// Total number of labels using this snippet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSnippetUsageResponse(
            bool? success,
            string? message,
            string? snippetName,
            global::System.Collections.Generic.IList<global::G.GetSnippetUsageResponseSnippetUsageItem>? snippetUsage,
            int? totalPromptsUsingSnippet,
            global::System.Collections.Generic.IList<global::G.GetSnippetUsageResponseLabelUsageItem>? labelUsage,
            int? totalLabelsUsingSnippet)
        {
            this.Success = success;
            this.Message = message;
            this.SnippetName = snippetName;
            this.SnippetUsage = snippetUsage;
            this.TotalPromptsUsingSnippet = totalPromptsUsingSnippet;
            this.LabelUsage = labelUsage;
            this.TotalLabelsUsingSnippet = totalLabelsUsingSnippet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponse" /> class.
        /// </summary>
        public GetSnippetUsageResponse()
        {
        }
    }
}