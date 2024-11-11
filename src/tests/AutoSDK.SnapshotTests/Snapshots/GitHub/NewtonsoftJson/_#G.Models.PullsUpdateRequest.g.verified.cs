//HintName: G.Models.PullsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullsUpdateRequest
    {
        /// <summary>
        /// The title of the pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The contents of the pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// State of this Pull Request. Either `open` or `closed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.PullsUpdateRequestState? State { get; set; }

        /// <summary>
        /// The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base")]
        public string? Base { get; set; }

        /// <summary>
        /// Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainer_can_modify")]
        public bool? MaintainerCanModify { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the pull request.
        /// </param>
        /// <param name="body">
        /// The contents of the pull request.
        /// </param>
        /// <param name="state">
        /// State of this Pull Request. Either `open` or `closed`.
        /// </param>
        /// <param name="base">
        /// The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository.
        /// </param>
        /// <param name="maintainerCanModify">
        /// Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request.
        /// </param>
        public PullsUpdateRequest(
            string? title,
            string? body,
            global::G.PullsUpdateRequestState? state,
            string? @base,
            bool? maintainerCanModify)
        {
            this.Title = title;
            this.Body = body;
            this.State = state;
            this.Base = @base;
            this.MaintainerCanModify = maintainerCanModify;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullsUpdateRequest" /> class.
        /// </summary>
        public PullsUpdateRequest()
        {
        }
    }
}