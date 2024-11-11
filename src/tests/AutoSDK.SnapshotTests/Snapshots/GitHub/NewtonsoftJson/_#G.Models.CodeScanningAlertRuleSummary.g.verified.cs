//HintName: G.Models.CodeScanningAlertRuleSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAlertRuleSummary
    {
        /// <summary>
        /// A unique identifier for the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The severity of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("severity")]
        public global::G.CodeScanningAlertRuleSummarySeverity? Severity { get; set; }

        /// <summary>
        /// The security severity of the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_severity_level")]
        public global::G.CodeScanningAlertRuleSummarySecuritySeverityLevel? SecuritySeverityLevel { get; set; }

        /// <summary>
        /// A short description of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A description of the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("full_description")]
        public string? FullDescription { get; set; }

        /// <summary>
        /// A set of tags applicable for the rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Detailed documentation for the rule as GitHub Flavored Markdown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help")]
        public string? Help { get; set; }

        /// <summary>
        /// A link to the documentation for the rule used to detect the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("help_uri")]
        public string? HelpUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertRuleSummary" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the rule used to detect the alert.
        /// </param>
        /// <param name="name">
        /// The name of the rule used to detect the alert.
        /// </param>
        /// <param name="severity">
        /// The severity of the alert.
        /// </param>
        /// <param name="securitySeverityLevel">
        /// The security severity of the alert.
        /// </param>
        /// <param name="description">
        /// A short description of the rule used to detect the alert.
        /// </param>
        /// <param name="fullDescription">
        /// A description of the rule used to detect the alert.
        /// </param>
        /// <param name="tags">
        /// A set of tags applicable for the rule.
        /// </param>
        /// <param name="help">
        /// Detailed documentation for the rule as GitHub Flavored Markdown.
        /// </param>
        /// <param name="helpUri">
        /// A link to the documentation for the rule used to detect the alert.
        /// </param>
        public CodeScanningAlertRuleSummary(
            string? id,
            string? name,
            global::G.CodeScanningAlertRuleSummarySeverity? severity,
            global::G.CodeScanningAlertRuleSummarySecuritySeverityLevel? securitySeverityLevel,
            string? description,
            string? fullDescription,
            global::System.Collections.Generic.IList<string>? tags,
            string? help,
            string? helpUri)
        {
            this.Id = id;
            this.Name = name;
            this.Severity = severity;
            this.SecuritySeverityLevel = securitySeverityLevel;
            this.Description = description;
            this.FullDescription = fullDescription;
            this.Tags = tags;
            this.Help = help;
            this.HelpUri = helpUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAlertRuleSummary" /> class.
        /// </summary>
        public CodeScanningAlertRuleSummary()
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
        public static global::G.CodeScanningAlertRuleSummary? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CodeScanningAlertRuleSummary>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CodeScanningAlertRuleSummary?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CodeScanningAlertRuleSummary?>(serializer.Deserialize<global::G.CodeScanningAlertRuleSummary>(jsonReader));
        }

    }
}