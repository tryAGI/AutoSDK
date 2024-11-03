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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pushed_at")]
        public global::System.DateTime? PushedAt { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` enforcement status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RuleSuiteResult2JsonConverter))]
        public global::G.RuleSuiteResult2? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`. Null if no rules with `evaluate` enforcement status were run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RuleSuiteEvaluationResult2JsonConverter))]
        public global::G.RuleSuiteEvaluationResult2? EvaluationResult { get; set; }

        /// <summary>
        /// Details on the evaluated rules.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_evaluations")]
        public global::System.Collections.Generic.IList<global::G.RuleSuiteRuleEvaluation>? RuleEvaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.RuleSuite2? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RuleSuite2),
                jsonSerializerContext) as global::G.RuleSuite2;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RuleSuite2>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.RuleSuite2?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.RuleSuite2),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.RuleSuite2;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RuleSuite2?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.RuleSuite2?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}