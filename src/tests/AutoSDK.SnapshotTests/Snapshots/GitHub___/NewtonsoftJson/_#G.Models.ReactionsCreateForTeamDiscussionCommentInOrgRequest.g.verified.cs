//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionsCreateForTeamDiscussionCommentInOrgRequest
    {
        /// <summary>
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionCommentInOrgRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
        /// </param>
        public ReactionsCreateForTeamDiscussionCommentInOrgRequest(
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionCommentInOrgRequest" /> class.
        /// </summary>
        public ReactionsCreateForTeamDiscussionCommentInOrgRequest()
        {
        }
    }
}