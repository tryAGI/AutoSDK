//HintName: G.Models.TeamsCreateDiscussionCommentInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsCreateDiscussionCommentInOrgRequest
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
        /// Initializes a new instance of the <see cref="TeamsCreateDiscussionCommentInOrgRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The discussion comment's body text.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TeamsCreateDiscussionCommentInOrgRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateDiscussionCommentInOrgRequest" /> class.
        /// </summary>
        public TeamsCreateDiscussionCommentInOrgRequest()
        {
        }
    }
}