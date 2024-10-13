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
        public global::G.RuleSuiteResult? Result { get; set; }

        /// <summary>
        /// The result of the rule evaluations for rules with the `active` and `evaluate` enforcement statuses, demonstrating whether rules would pass or fail if all rules in the rule suite were `active`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_result")]
        public global::G.RuleSuiteEvaluationResult? EvaluationResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.RuleSuite? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RuleSuite>(
                json,
                jsonSerializerOptions);
        }

    }
}