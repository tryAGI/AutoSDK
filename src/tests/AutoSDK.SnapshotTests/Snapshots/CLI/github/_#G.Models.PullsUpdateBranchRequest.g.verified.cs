﻿//HintName: G.Models.PullsUpdateBranchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsUpdateBranchRequest
    {
        /// <summary>
        /// The expected SHA of the pull request's HEAD ref. This is the most recent commit on the pull request's branch. If the expected SHA does not match the pull request's HEAD, you will receive a `422 Unprocessable Entity` status. You can use the "[List commits](https://docs.github.com/rest/commits/commits#list-commits)" endpoint to find the most recent commit SHA. Default: SHA of the pull request's current HEAD ref.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_head_sha")]
        public string? ExpectedHeadSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateBranchRequest" /> class.
        /// </summary>
        /// <param name="expectedHeadSha">
        /// The expected SHA of the pull request's HEAD ref. This is the most recent commit on the pull request's branch. If the expected SHA does not match the pull request's HEAD, you will receive a `422 Unprocessable Entity` status. You can use the "[List commits](https://docs.github.com/rest/commits/commits#list-commits)" endpoint to find the most recent commit SHA. Default: SHA of the pull request's current HEAD ref.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullsUpdateBranchRequest(
            string? expectedHeadSha)
        {
            this.ExpectedHeadSha = expectedHeadSha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateBranchRequest" /> class.
        /// </summary>
        public PullsUpdateBranchRequest()
        {
        }
    }
}