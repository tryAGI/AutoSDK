//HintName: G.Models.PostCliCodactFailuresRequestToolInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional tool metadata when the failure can be tied to a toolkit or concrete tool version.<br/>
    /// Example: {"toolkit":"github","tool":{"slug":"GITHUB_CREATE_ISSUE","version":"2026.03.23"}}
    /// </summary>
    public sealed partial class PostCliCodactFailuresRequestToolInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        public string? Toolkit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        public global::G.PostCliCodactFailuresRequestToolInfoTool? Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresRequestToolInfo" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="tool"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCliCodactFailuresRequestToolInfo(
            string? toolkit,
            global::G.PostCliCodactFailuresRequestToolInfoTool? tool)
        {
            this.Toolkit = toolkit;
            this.Tool = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCodactFailuresRequestToolInfo" /> class.
        /// </summary>
        public PostCliCodactFailuresRequestToolInfo()
        {
        }
    }
}