//HintName: G.Models.RepositoryAdvisoryCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryCreate
    {
        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        /// A detailed description of what the advisory impacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateVulnerabilitie> Vulnerabilities { get; set; }

        /// <summary>
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cwe_ids")]
        public global::System.Collections.Generic.IList<string>? CweIds { get; set; }

        /// <summary>
        /// A list of users receiving credit for their participation in the security advisory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryCreateCredit>? Credits { get; set; }

        /// <summary>
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryAdvisoryCreateSeverityJsonConverter))]
        public global::G.RepositoryAdvisoryCreateSeverity? Severity { get; set; }

        /// <summary>
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cvss_vector_string")]
        public string? CvssVectorString { get; set; }

        /// <summary>
        /// Whether to create a temporary private fork of the repository to collaborate on a fix.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_private_fork")]
        public bool? StartPrivateFork { get; set; }

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
        public static global::G.RepositoryAdvisoryCreate? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.RepositoryAdvisoryCreate),
                jsonSerializerContext) as global::G.RepositoryAdvisoryCreate;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryAdvisoryCreate? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.RepositoryAdvisoryCreate>(
                json,
                jsonSerializerOptions);
        }

    }
}