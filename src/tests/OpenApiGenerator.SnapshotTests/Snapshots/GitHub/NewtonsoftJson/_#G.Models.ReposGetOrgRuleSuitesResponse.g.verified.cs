//HintName: G.Models.ReposGetOrgRuleSuitesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposGetOrgRuleSuitesResponse
    {
        /// <summary>
        /// The unique identifier of the rule insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The number that identifies the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor_id")]
        public int ActorId { get; set; }

        /// <summary>
        /// The handle for the GitHub user account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor_name")]
        public string? ActorName { get; set; }

        /// <summary>
        /// The first commit sha before the push evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("before_sha")]
        public string? BeforeSha { get; set; }

        /// <summary>
        /// The last commit sha in the push evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_sha")]
        public string? AfterSha { get; set; }

        /// <summary>
        /// The ref name that the evaluation ran on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The ID of the repository associated with the rule evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_id")]
        public int RepositoryId { get; set; }

        /// <summary>
        /// The name of the repository without the `.git` extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_name")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pushed_at")]
        public global::System.DateTime PushedAt { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public ReposGetOrgRuleSuitesResponseResult? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_result")]
        public ReposGetOrgRuleSuitesResponseEvaluationResult? EvaluationResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}