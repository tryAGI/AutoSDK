﻿//HintName: G.Models.ReactionsCreateForTeamDiscussionLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionsCreateForTeamDiscussionLegacyRequest
    {
        /// <summary>
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReactionsCreateForTeamDiscussionLegacyRequestContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReactionsCreateForTeamDiscussionLegacyRequestContent Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionLegacyRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReactionsCreateForTeamDiscussionLegacyRequest(
            global::G.ReactionsCreateForTeamDiscussionLegacyRequestContent content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForTeamDiscussionLegacyRequest" /> class.
        /// </summary>
        public ReactionsCreateForTeamDiscussionLegacyRequest()
        {
        }
    }
}