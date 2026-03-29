//HintName: G.Models.ChatStreamOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Streaming configuration options
    /// </summary>
    public sealed partial class ChatStreamOptions
    {
        /// <summary>
        /// Deprecated: This field has no effect. Full usage details are always included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// Deprecated: This field has no effect. Full usage details are always included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamOptions" /> class.
        /// </summary>
        public ChatStreamOptions()
        {
        }
    }
}