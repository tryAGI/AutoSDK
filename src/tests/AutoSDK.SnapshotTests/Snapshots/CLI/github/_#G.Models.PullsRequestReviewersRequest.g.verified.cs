﻿//HintName: G.Models.PullsRequestReviewersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsRequestReviewersRequest
    {
        /// <summary>
        /// An array of user `login`s that will be requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<string>? Reviewers { get; set; }

        /// <summary>
        /// An array of team `slug`s that will be requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_reviewers")]
        public global::System.Collections.Generic.IList<string>? TeamReviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsRequestReviewersRequest" /> class.
        /// </summary>
        /// <param name="reviewers">
        /// An array of user `login`s that will be requested.
        /// </param>
        /// <param name="teamReviewers">
        /// An array of team `slug`s that will be requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullsRequestReviewersRequest(
            global::System.Collections.Generic.IList<string>? reviewers,
            global::System.Collections.Generic.IList<string>? teamReviewers)
        {
            this.Reviewers = reviewers;
            this.TeamReviewers = teamReviewers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsRequestReviewersRequest" /> class.
        /// </summary>
        public PullsRequestReviewersRequest()
        {
        }
    }
}