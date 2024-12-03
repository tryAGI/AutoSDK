//HintName: G.Models.SecretScanningLocationDiscussionComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'discussion_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a discussion.
    /// </summary>
    public sealed partial class SecretScanningLocationDiscussionComment
    {
        /// <summary>
        /// The API URL to get the discussion comment where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussioncomment-4158232
        /// </summary>
        /// <example>https://github.com/community/community/discussions/39082#discussioncomment-4158232</example>
        [global::Newtonsoft.Json.JsonProperty("discussion_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionCommentUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionComment" /> class.
        /// </summary>
        /// <param name="discussionCommentUrl">
        /// The API URL to get the discussion comment where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussioncomment-4158232
        /// </param>
        public SecretScanningLocationDiscussionComment(
            string discussionCommentUrl)
        {
            this.DiscussionCommentUrl = discussionCommentUrl ?? throw new global::System.ArgumentNullException(nameof(discussionCommentUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionComment" /> class.
        /// </summary>
        public SecretScanningLocationDiscussionComment()
        {
        }
    }
}