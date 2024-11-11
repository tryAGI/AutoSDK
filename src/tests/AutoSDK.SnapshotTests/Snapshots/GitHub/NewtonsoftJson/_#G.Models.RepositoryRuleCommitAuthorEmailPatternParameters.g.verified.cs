//HintName: G.Models.RepositoryRuleCommitAuthorEmailPatternParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleCommitAuthorEmailPatternParameters
    {
        /// <summary>
        /// How this rule will appear to users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, the rule will fail if the pattern matches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negate")]
        public bool? Negate { get; set; }

        /// <summary>
        /// The operator to use for matching.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleCommitAuthorEmailPatternParametersOperator Operator { get; set; } = default!;

        /// <summary>
        /// The pattern to match with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPatternParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// How this rule will appear to users.
        /// </param>
        /// <param name="negate">
        /// If true, the rule will fail if the pattern matches.
        /// </param>
        /// <param name="operator">
        /// The operator to use for matching.
        /// </param>
        /// <param name="pattern">
        /// The pattern to match with.
        /// </param>
        public RepositoryRuleCommitAuthorEmailPatternParameters(
            global::G.RepositoryRuleCommitAuthorEmailPatternParametersOperator @operator,
            string pattern,
            string? name,
            bool? negate)
        {
            this.Operator = @operator;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Name = name;
            this.Negate = negate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPatternParameters" /> class.
        /// </summary>
        public RepositoryRuleCommitAuthorEmailPatternParameters()
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
        public static global::G.RepositoryRuleCommitAuthorEmailPatternParameters? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryRuleCommitAuthorEmailPatternParameters>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleCommitAuthorEmailPatternParameters?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryRuleCommitAuthorEmailPatternParameters?>(serializer.Deserialize<global::G.RepositoryRuleCommitAuthorEmailPatternParameters>(jsonReader));
        }

    }
}