//HintName: G.Models.TeamsUpdateDiscussionCommentLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsUpdateDiscussionCommentLegacyRequest
    {
        /// <summary>
        /// The discussion comment's body text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateDiscussionCommentLegacyRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The discussion comment's body text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsUpdateDiscussionCommentLegacyRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateDiscussionCommentLegacyRequest" /> class.
        /// </summary>
        public TeamsUpdateDiscussionCommentLegacyRequest()
        {
        }
    }
}