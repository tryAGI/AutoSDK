//HintName: G.Models.DependencyGraphDiffItemVulnerabilitie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphDiffItemVulnerabilitie
    {
        /// <summary>
        /// Example: critical
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Severity { get; set; }

        /// <summary>
        /// Example: GHSA-rf4j-j272-fj86
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_ghsa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryGhsaId { get; set; }

        /// <summary>
        /// Example: A summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisorySummary { get; set; }

        /// <summary>
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisory_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AdvisoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItemVulnerabilitie" /> class.
        /// </summary>
        /// <param name="severity">
        /// Example: critical
        /// </param>
        /// <param name="advisoryGhsaId">
        /// Example: GHSA-rf4j-j272-fj86
        /// </param>
        /// <param name="advisorySummary">
        /// Example: A summary of the advisory.
        /// </param>
        /// <param name="advisoryUrl">
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependencyGraphDiffItemVulnerabilitie(
            string severity,
            string advisoryGhsaId,
            string advisorySummary,
            string advisoryUrl)
        {
            this.Severity = severity ?? throw new global::System.ArgumentNullException(nameof(severity));
            this.AdvisoryGhsaId = advisoryGhsaId ?? throw new global::System.ArgumentNullException(nameof(advisoryGhsaId));
            this.AdvisorySummary = advisorySummary ?? throw new global::System.ArgumentNullException(nameof(advisorySummary));
            this.AdvisoryUrl = advisoryUrl ?? throw new global::System.ArgumentNullException(nameof(advisoryUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphDiffItemVulnerabilitie" /> class.
        /// </summary>
        public DependencyGraphDiffItemVulnerabilitie()
        {
        }


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
        public static global::G.DependencyGraphDiffItemVulnerabilitie? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.DependencyGraphDiffItemVulnerabilitie),
                jsonSerializerContext) as global::G.DependencyGraphDiffItemVulnerabilitie;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.DependencyGraphDiffItemVulnerabilitie? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.DependencyGraphDiffItemVulnerabilitie>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItemVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.DependencyGraphDiffItemVulnerabilitie),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.DependencyGraphDiffItemVulnerabilitie;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItemVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.DependencyGraphDiffItemVulnerabilitie?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}