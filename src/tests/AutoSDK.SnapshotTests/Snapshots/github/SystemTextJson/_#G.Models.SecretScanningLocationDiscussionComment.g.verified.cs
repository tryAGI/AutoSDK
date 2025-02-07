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
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion_comment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiscussionCommentUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionComment" /> class.
        /// </summary>
        /// <param name="discussionCommentUrl">
        /// The API URL to get the discussion comment where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussioncomment-4158232
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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