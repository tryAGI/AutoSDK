//HintName: G.Models.DiscussionResultData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The discussion data.
    /// </summary>
    public sealed partial class DiscussionResultData
    {
        /// <summary>
        /// Title of the discussion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the discussion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Description or snippet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Human-readable age.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Page age (ISO 8601).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// Aggregated URL information for a result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_url")]
        public global::G.MetaUrl? MetaUrl { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Name of the forum (e.g., Reddit).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("forum_name")]
        public string? ForumName { get; set; }

        /// <summary>
        /// Number of answers/comments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_answers")]
        public int? NumAnswers { get; set; }

        /// <summary>
        /// Score/upvotes on the post.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public string? Score { get; set; }

        /// <summary>
        /// The question text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// The top/best comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_comment")]
        public string? TopComment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionResultData" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the discussion.
        /// </param>
        /// <param name="url">
        /// URL of the discussion.
        /// </param>
        /// <param name="description">
        /// Description or snippet.
        /// </param>
        /// <param name="age">
        /// Human-readable age.
        /// </param>
        /// <param name="pageAge">
        /// Page age (ISO 8601).
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="forumName">
        /// Name of the forum (e.g., Reddit).
        /// </param>
        /// <param name="numAnswers">
        /// Number of answers/comments.
        /// </param>
        /// <param name="score">
        /// Score/upvotes on the post.
        /// </param>
        /// <param name="question">
        /// The question text.
        /// </param>
        /// <param name="topComment">
        /// The top/best comment.
        /// </param>
        public DiscussionResultData(
            string? title,
            string? url,
            string? description,
            string? age,
            string? pageAge,
            global::G.MetaUrl? metaUrl,
            global::G.Thumbnail? thumbnail,
            string? forumName,
            int? numAnswers,
            string? score,
            string? question,
            string? topComment)
        {
            this.Title = title;
            this.Url = url;
            this.Description = description;
            this.Age = age;
            this.PageAge = pageAge;
            this.MetaUrl = metaUrl;
            this.Thumbnail = thumbnail;
            this.ForumName = forumName;
            this.NumAnswers = numAnswers;
            this.Score = score;
            this.Question = question;
            this.TopComment = topComment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionResultData" /> class.
        /// </summary>
        public DiscussionResultData()
        {
        }
    }
}