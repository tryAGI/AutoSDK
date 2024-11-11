//HintName: G.Models.RuleSuite2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response
    /// </summary>
    public sealed partial class RuleSuite2
    {
        /// <summary>
        /// The unique identifier of the rule insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The number that identifies the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actor_id")]
        public int? ActorId { get; set; }

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
        public int? RepositoryId { get; set; }

        /// <summary>
        /// The name of the repository without the `.git` extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository_name")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pushed_at")]
        public global::System.DateTime? PushedAt { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result")]
        public global::G.RuleSuiteResult2? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`. Null if no rules with `evaluate` enforcement status were run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_result")]
        public global::G.RuleSuiteEvaluationResult2? EvaluationResult { get; set; }

        /// <summary>
        /// Details on the evaluated rules.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_evaluations")]
        public global::System.Collections.Generic.IList<global::G.RuleSuiteRuleEvaluation>? RuleEvaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuite2" /> class.
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
        /// <param name="pushedAt"></param>
        /// <param name="result">
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </param>
        /// <param name="evaluationResult">
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`. Null if no rules with `evaluate` enforcement status were run.
        /// </param>
        /// <param name="ruleEvaluations">
        /// Details on the evaluated rules.
        /// </param>
        public RuleSuite2(
            int? id,
            int? actorId,
            string? actorName,
            string? beforeSha,
            string? afterSha,
            string? @ref,
            int? repositoryId,
            string? repositoryName,
            global::System.DateTime? pushedAt,
            global::G.RuleSuiteResult2? result,
            global::G.RuleSuiteEvaluationResult2? evaluationResult,
            global::System.Collections.Generic.IList<global::G.RuleSuiteRuleEvaluation>? ruleEvaluations)
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
            this.RuleEvaluations = ruleEvaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuite2" /> class.
        /// </summary>
        public RuleSuite2()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RuleSuite2? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RuleSuite2>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RuleSuite2?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RuleSuite2?>(serializer.Deserialize<global::G.RuleSuite2>(jsonReader));
        }

    }
}