﻿//HintName: G.Models.ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SimpleUser> Users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Team> Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="teams"></param>
        /// <param name="apps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances(
            global::System.Collections.Generic.IList<global::G.SimpleUser> users,
            global::System.Collections.Generic.IList<global::G.Team> teams,
            global::System.Collections.Generic.IList<global::G.Integration>? apps)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances" /> class.
        /// </summary>
        public ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances()
        {
        }
    }
}