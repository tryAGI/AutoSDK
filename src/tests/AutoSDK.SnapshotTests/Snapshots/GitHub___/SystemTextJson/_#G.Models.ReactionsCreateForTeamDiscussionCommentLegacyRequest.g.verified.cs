//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionsCreateForTeamDiscussionCommentLegacyRequest
    {
        /// <summary>
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionCommentLegacyRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReactionsCreateForTeamDiscussionCommentLegacyRequest(
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionCommentLegacyRequest" /> class.
        /// </summary>
        public ReactionsCreateForTeamDiscussionCommentLegacyRequest()
        {
        }
    }
}