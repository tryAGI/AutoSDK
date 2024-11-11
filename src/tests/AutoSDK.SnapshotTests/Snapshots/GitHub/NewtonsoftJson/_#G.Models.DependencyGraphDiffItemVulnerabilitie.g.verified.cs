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
        [global::Newtonsoft.Json.JsonProperty("severity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Severity { get; set; } = default!;

        /// <summary>
        /// Example: GHSA-rf4j-j272-fj86
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_ghsa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryGhsaId { get; set; } = default!;

        /// <summary>
        /// Example: A summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisorySummary { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/advisories/GHSA-rf4j-j272-fj86
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("advisory_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AdvisoryUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.DependencyGraphDiffItemVulnerabilitie? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependencyGraphDiffItemVulnerabilitie>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItemVulnerabilitie?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependencyGraphDiffItemVulnerabilitie?>(serializer.Deserialize<global::G.DependencyGraphDiffItemVulnerabilitie>(jsonReader));
        }

    }
}