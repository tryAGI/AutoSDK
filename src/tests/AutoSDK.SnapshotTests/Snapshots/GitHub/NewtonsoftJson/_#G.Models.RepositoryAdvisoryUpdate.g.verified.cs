//HintName: G.Models.RepositoryAdvisoryUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdate
    {
        /// <summary>
        /// A short summary of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// A detailed description of what the advisory impacts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>? Vulnerabilities { get; set; }

        /// <summary>
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cwe_ids")]
        public global::System.Collections.Generic.IList<string>? CweIds { get; set; }

        /// <summary>
        /// A list of users receiving credit for their participation in the security advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits")]
        public global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>? Credits { get; set; }

        /// <summary>
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.RepositoryAdvisoryUpdateSeverity? Severity { get; set; }

        /// <summary>
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss_vector_string")]
        public string? CvssVectorString { get; set; }

        /// <summary>
        /// The state of the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.RepositoryAdvisoryUpdateState? State { get; set; }

        /// <summary>
        /// A list of usernames who have been granted write access to the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborating_users")]
        public global::System.Collections.Generic.IList<string>? CollaboratingUsers { get; set; }

        /// <summary>
        /// A list of team slugs which have been granted write access to the advisory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collaborating_teams")]
        public global::System.Collections.Generic.IList<string>? CollaboratingTeams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdate" /> class.
        /// </summary>
        /// <param name="summary">
        /// A short summary of the advisory.
        /// </param>
        /// <param name="description">
        /// A detailed description of what the advisory impacts.
        /// </param>
        /// <param name="cveId">
        /// The Common Vulnerabilities and Exposures (CVE) ID.
        /// </param>
        /// <param name="vulnerabilities">
        /// A product affected by the vulnerability detailed in a repository security advisory.
        /// </param>
        /// <param name="cweIds">
        /// A list of Common Weakness Enumeration (CWE) IDs.
        /// </param>
        /// <param name="credits">
        /// A list of users receiving credit for their participation in the security advisory.
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory. You must choose between setting this field or `cvss_vector_string`.
        /// </param>
        /// <param name="cvssVectorString">
        /// The CVSS vector that calculates the severity of the advisory. You must choose between setting this field or `severity`.
        /// </param>
        /// <param name="state">
        /// The state of the advisory.
        /// </param>
        /// <param name="collaboratingUsers">
        /// A list of usernames who have been granted write access to the advisory.
        /// </param>
        /// <param name="collaboratingTeams">
        /// A list of team slugs which have been granted write access to the advisory.
        /// </param>
        public RepositoryAdvisoryUpdate(
            string? summary,
            string? description,
            string? cveId,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateVulnerabilitie>? vulnerabilities,
            global::System.Collections.Generic.IList<string>? cweIds,
            global::System.Collections.Generic.IList<global::G.RepositoryAdvisoryUpdateCredit>? credits,
            global::G.RepositoryAdvisoryUpdateSeverity? severity,
            string? cvssVectorString,
            global::G.RepositoryAdvisoryUpdateState? state,
            global::System.Collections.Generic.IList<string>? collaboratingUsers,
            global::System.Collections.Generic.IList<string>? collaboratingTeams)
        {
            this.Summary = summary;
            this.Description = description;
            this.CveId = cveId;
            this.Vulnerabilities = vulnerabilities;
            this.CweIds = cweIds;
            this.Credits = credits;
            this.Severity = severity;
            this.CvssVectorString = cvssVectorString;
            this.State = state;
            this.CollaboratingUsers = collaboratingUsers;
            this.CollaboratingTeams = collaboratingTeams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdate" /> class.
        /// </summary>
        public RepositoryAdvisoryUpdate()
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
        public static global::G.RepositoryAdvisoryUpdate? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryAdvisoryUpdate>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryUpdate?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryAdvisoryUpdate?>(serializer.Deserialize<global::G.RepositoryAdvisoryUpdate>(jsonReader));
        }

    }
}