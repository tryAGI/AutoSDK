//HintName: G.Models.DependabotAlertSecurityAdvisory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for the GitHub Security Advisory.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisory
    {
        /// <summary>
        /// The unique GitHub Security Advisory ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("ghsa_id")]
        public string GhsaId { get; set; } = default!;

        /// <summary>
        /// The unique CVE ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cve_id")]
        public string? CveId { get; set; }

        /// <summary>
        /// A short, plain text summary of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string Summary { get; set; } = default!;

        /// <summary>
        /// A long-form Markdown-supported description of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Vulnerable version range information for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("vulnerabilities")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityVulnerability> Vulnerabilities { get; set; } = default!;

        /// <summary>
        /// The severity of the advisory.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.DependabotAlertSecurityAdvisorySeverity Severity { get; set; } = default!;

        /// <summary>
        /// Details for the advisory pertaining to the Common Vulnerability Scoring System.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("cvss")]
        public global::G.DependabotAlertSecurityAdvisoryCvss Cvss { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cvss_severities")]
        public global::G.CvssSeverities? CvssSeverities { get; set; }

        /// <summary>
        /// Details for the advisory pertaining to Common Weakness Enumeration.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("cwes")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryCwe> Cwes { get; set; } = default!;

        /// <summary>
        /// Values that identify this advisory among security information sources.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("identifiers")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryIdentifier> Identifiers { get; set; } = default!;

        /// <summary>
        /// Links to additional advisory information.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("references")]
        public global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryReference> References { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was published in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("published_at")]
        public global::System.DateTime PublishedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was last modified in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the advisory was withdrawn in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("withdrawn_at")]
        public global::System.DateTime? WithdrawnAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisory" /> class.
        /// </summary>
        /// <param name="ghsaId">
        /// The unique GitHub Security Advisory ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cveId">
        /// The unique CVE ID assigned to the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="summary">
        /// A short, plain text summary of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// A long-form Markdown-supported description of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="vulnerabilities">
        /// Vulnerable version range information for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="severity">
        /// The severity of the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cvss">
        /// Details for the advisory pertaining to the Common Vulnerability Scoring System.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cvssSeverities"></param>
        /// <param name="cwes">
        /// Details for the advisory pertaining to Common Weakness Enumeration.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="identifiers">
        /// Values that identify this advisory among security information sources.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="references">
        /// Links to additional advisory information.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="publishedAt">
        /// The time that the advisory was published in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the advisory was last modified in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="withdrawnAt">
        /// The time that the advisory was withdrawn in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        public DependabotAlertSecurityAdvisory(
            string? cveId,
            global::G.CvssSeverities? cvssSeverities,
            global::System.DateTime? withdrawnAt,
            string ghsaId = default!,
            string summary = default!,
            string description = default!,
            global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityVulnerability> vulnerabilities = default!,
            global::G.DependabotAlertSecurityAdvisorySeverity severity = default!,
            global::G.DependabotAlertSecurityAdvisoryCvss cvss = default!,
            global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryCwe> cwes = default!,
            global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryIdentifier> identifiers = default!,
            global::System.Collections.Generic.IList<global::G.DependabotAlertSecurityAdvisoryReference> references = default!,
            global::System.DateTime publishedAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.GhsaId = ghsaId;
            this.CveId = cveId;
            this.Summary = summary;
            this.Description = description;
            this.Vulnerabilities = vulnerabilities;
            this.Severity = severity;
            this.Cvss = cvss;
            this.CvssSeverities = cvssSeverities;
            this.Cwes = cwes;
            this.Identifiers = identifiers;
            this.References = references;
            this.PublishedAt = publishedAt;
            this.UpdatedAt = updatedAt;
            this.WithdrawnAt = withdrawnAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisory" /> class.
        /// </summary>
        public DependabotAlertSecurityAdvisory()
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
        public static global::G.DependabotAlertSecurityAdvisory? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependabotAlertSecurityAdvisory>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependabotAlertSecurityAdvisory?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependabotAlertSecurityAdvisory?>(serializer.Deserialize<global::G.DependabotAlertSecurityAdvisory>(jsonReader));
        }

    }
}