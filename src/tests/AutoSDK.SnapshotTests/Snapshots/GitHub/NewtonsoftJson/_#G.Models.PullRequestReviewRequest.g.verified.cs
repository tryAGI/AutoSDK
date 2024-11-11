//HintName: G.Models.PullRequestReviewRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pull Request Review Request
    /// </summary>
    public sealed partial class PullRequestReviewRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SimpleUser> Users { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Team> Teams { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewRequest" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="teams"></param>
        public PullRequestReviewRequest(
            global::System.Collections.Generic.IList<global::G.SimpleUser> users,
            global::System.Collections.Generic.IList<global::G.Team> teams)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestReviewRequest" /> class.
        /// </summary>
        public PullRequestReviewRequest()
        {
        }
    }
}