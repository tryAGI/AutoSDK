//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant2Reactions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssueCommentDeletedIssueVariant2Reactions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("+1")]
        public int? Plus1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("-1")]
        public int? Minus1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confused")]
        public int? Confused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eyes")]
        public int? Eyes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart")]
        public int? Heart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooray")]
        public int? Hooray { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("laugh")]
        public int? Laugh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rocket")]
        public int? Rocket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookIssueCommentDeletedIssueVariant2Reactions" /> class.
        /// </summary>
        /// <param name="plus1"></param>
        /// <param name="minus1"></param>
        /// <param name="confused"></param>
        /// <param name="eyes"></param>
        /// <param name="heart"></param>
        /// <param name="hooray"></param>
        /// <param name="laugh"></param>
        /// <param name="rocket"></param>
        /// <param name="totalCount"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssueCommentDeletedIssueVariant2Reactions(
            int? plus1,
            int? minus1,
            int? confused,
            int? eyes,
            int? heart,
            int? hooray,
            int? laugh,
            int? rocket,
            int? totalCount,
            string? url)
        {
            this.Plus1 = plus1;
            this.Minus1 = minus1;
            this.Confused = confused;
            this.Eyes = eyes;
            this.Heart = heart;
            this.Hooray = hooray;
            this.Laugh = laugh;
            this.Rocket = rocket;
            this.TotalCount = totalCount;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentDeletedIssueVariant2Reactions" /> class.
        /// </summary>
        public WebhookIssueCommentDeletedIssueVariant2Reactions()
        {
        }
    }
}