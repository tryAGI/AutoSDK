//HintName: G.Models.RuleSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleSuite
    {
        /// <summary>
        /// The unique identifier of the rule insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The number that identifies the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_id")]
        public int? ActorId { get; set; }

        /// <summary>
        /// The handle for the GitHub user account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor_name")]
        public string? ActorName { get; set; }

        /// <summary>
        /// The first commit sha before the push evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_sha")]
        public string? BeforeSha { get; set; }

        /// <summary>
        /// The last commit sha in the push evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_sha")]
        public string? AfterSha { get; set; }

        /// <summary>
        /// The ref name that the evaluation ran on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

        /// <summary>
        /// The ID of the repository associated with the rule evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// The name of the repository without the `.git` extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_name")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:06:43Z
        /// </summary>
        /// <example>2011-01-26T19:06:43Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        public global::System.DateTime? PushedAt { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RuleSuiteResultJsonConverter))]
        public global::G.RuleSuiteResult? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RuleSuiteEvaluationResultJsonConverter))]
        public global::G.RuleSuiteEvaluationResult? EvaluationResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuite" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the rule insight.
        /// </param>
        /// <param name="actorId">
        /// The number that identifies the user.
        /// </param>
        /// <param name="actorName">
        /// The handle for the GitHub user account.
        /// </param>
        /// <param name="beforeSha">
        /// The first commit sha before the push evaluation.
        /// </param>
        /// <param name="afterSha">
        /// The last commit sha in the push evaluation.
        /// </param>
        /// <param name="ref">
        /// The ref name that the evaluation ran on.
        /// </param>
        /// <param name="repositoryId">
        /// The ID of the repository associated with the rule evaluation.
        /// </param>
        /// <param name="repositoryName">
        /// The name of the repository without the `.git` extension.
        /// </param>
        /// <param name="pushedAt">
        /// Example: 2011-01-26T19:06:43Z
        /// </param>
        /// <param name="result">
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </param>
        /// <param name="evaluationResult">
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuite(
            int? id,
            int? actorId,
            string? actorName,
            string? beforeSha,
            string? afterSha,
            string? @ref,
            int? repositoryId,
            string? repositoryName,
            global::System.DateTime? pushedAt,
            global::G.RuleSuiteResult? result,
            global::G.RuleSuiteEvaluationResult? evaluationResult)
        {
            this.Id = id;
            this.ActorId = actorId;
            this.ActorName = actorName;
            this.BeforeSha = beforeSha;
            this.AfterSha = afterSha;
            this.Ref = @ref;
            this.RepositoryId = repositoryId;
            this.RepositoryName = repositoryName;
            this.PushedAt = pushedAt;
            this.Result = result;
            this.EvaluationResult = evaluationResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuite" /> class.
        /// </summary>
        public RuleSuite()
        {
        }
    }
}