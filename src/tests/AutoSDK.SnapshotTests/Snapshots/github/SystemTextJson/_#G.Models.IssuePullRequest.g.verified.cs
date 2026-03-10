//HintName: G.Models.IssuePullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuePullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merged_at")]
        public global::System.DateTime? MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff_url")]
        public string? DiffUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch_url")]
        public string? PatchUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuePullRequest" /> class.
        /// </summary>
        /// <param name="mergedAt"></param>
        /// <param name="diffUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="patchUrl"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuePullRequest(
            global::System.DateTime? mergedAt,
            string? diffUrl,
            string? htmlUrl,
            string? patchUrl,
            string? url)
        {
            this.MergedAt = mergedAt;
            this.DiffUrl = diffUrl;
            this.HtmlUrl = htmlUrl;
            this.PatchUrl = patchUrl;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuePullRequest" /> class.
        /// </summary>
        public IssuePullRequest()
        {
        }
    }
}