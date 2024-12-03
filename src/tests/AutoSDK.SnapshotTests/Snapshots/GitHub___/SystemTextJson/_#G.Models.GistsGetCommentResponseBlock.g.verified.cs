//HintName: G.Models.GistsGetCommentResponseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsGetCommentResponseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetCommentResponseBlock" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GistsGetCommentResponseBlock(
            string? reason,
            string? createdAt,
            string? htmlUrl)
        {
            this.Reason = reason;
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetCommentResponseBlock" /> class.
        /// </summary>
        public GistsGetCommentResponseBlock()
        {
        }
    }
}