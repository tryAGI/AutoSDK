//HintName: G.Models.ContentFileLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentFileLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public string? Git { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFileLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="git"></param>
        /// <param name="html"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFileLinks(
            string self,
            string? git,
            string? html)
        {
            this.Git = git;
            this.Html = html;
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFileLinks" /> class.
        /// </summary>
        public ContentFileLinks()
        {
        }
    }
}