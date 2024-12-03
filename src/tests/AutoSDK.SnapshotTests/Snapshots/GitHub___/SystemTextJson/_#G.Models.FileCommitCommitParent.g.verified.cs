//HintName: G.Models.FileCommitCommitParent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileCommitCommitParent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitParent" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="sha"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FileCommitCommitParent(
            string? url,
            string? htmlUrl,
            string? sha)
        {
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.Sha = sha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileCommitCommitParent" /> class.
        /// </summary>
        public FileCommitCommitParent()
        {
        }
    }
}