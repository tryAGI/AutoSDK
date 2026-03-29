//HintName: G.Models.GetSnippetUsageResponseSnippetUsageItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSnippetUsageResponseSnippetUsageItem
    {
        /// <summary>
        /// The ID of the prompt that uses this snippet
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_registry_id")]
        public int? PromptRegistryId { get; set; }

        /// <summary>
        /// The name of the prompt that uses this snippet
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_name")]
        public string? PromptName { get; set; }

        /// <summary>
        /// List of version numbers that use this snippet
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_numbers")]
        public global::System.Collections.Generic.IList<int>? VersionNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponseSnippetUsageItem" /> class.
        /// </summary>
        /// <param name="promptRegistryId">
        /// The ID of the prompt that uses this snippet
        /// </param>
        /// <param name="promptName">
        /// The name of the prompt that uses this snippet
        /// </param>
        /// <param name="versionNumbers">
        /// List of version numbers that use this snippet
        /// </param>
        public GetSnippetUsageResponseSnippetUsageItem(
            int? promptRegistryId,
            string? promptName,
            global::System.Collections.Generic.IList<int>? versionNumbers)
        {
            this.PromptRegistryId = promptRegistryId;
            this.PromptName = promptName;
            this.VersionNumbers = versionNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSnippetUsageResponseSnippetUsageItem" /> class.
        /// </summary>
        public GetSnippetUsageResponseSnippetUsageItem()
        {
        }
    }
}