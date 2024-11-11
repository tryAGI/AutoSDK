//HintName: G.Models.DependabotAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Dependabot alert.
    /// </summary>
    public sealed partial class DependabotAlert
    {
        /// <summary>
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The state of the Dependabot alert.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        public global::G.DependabotAlertState State { get; set; } = default!;

        /// <summary>
        /// Details for the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dependency")]
        public global::G.DependabotAlertDependency Dependency { get; set; } = default!;

        /// <summary>
        /// Details for the GitHub Security Advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_advisory")]
        public global::G.DependabotAlertSecurityAdvisory SecurityAdvisory { get; set; } = default!;

        /// <summary>
        /// Details pertaining to one vulnerable version range for the advisory.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("security_vulnerability")]
        public global::G.DependabotAlertSecurityVulnerability SecurityVulnerability { get; set; } = default!;

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string HtmlUrl { get; set; } = default!;

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_at")]
        public global::System.DateTime? DismissedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? DismissedBy { get; set; } = default!;

        /// <summary>
        /// The reason that the alert was dismissed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependabotAlertDismissedReason? DismissedReason { get; set; } = default!;

        /// <summary>
        /// An optional comment associated with the alert's dismissal.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dismissed_comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string? DismissedComment { get; set; } = default!;

        /// <summary>
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fixed_at")]
        public global::System.DateTime? FixedAt { get; set; }

        /// <summary>
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_dismissed_at")]
        public global::System.DateTime? AutoDismissedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlert" /> class.
        /// </summary>
        /// <param name="number">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="state">
        /// The state of the Dependabot alert.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dependency">
        /// Details for the vulnerable dependency.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="securityAdvisory">
        /// Details for the GitHub Security Advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="securityVulnerability">
        /// Details pertaining to one vulnerable version range for the advisory.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="dismissedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="dismissedReason">
        /// The reason that the alert was dismissed.
        /// </param>
        /// <param name="dismissedComment">
        /// An optional comment associated with the alert's dismissal.
        /// </param>
        /// <param name="fixedAt">
        /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="autoDismissedAt">
        /// The time that the alert was auto-dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        public DependabotAlert(
            global::G.NullableSimpleUser? dismissedBy,
            global::G.DependabotAlertDismissedReason? dismissedReason,
            string? dismissedComment,
            global::System.DateTime? dismissedAt,
            global::System.DateTime? fixedAt,
            global::System.DateTime? autoDismissedAt,
            int number = default!,
            global::G.DependabotAlertState state = default!,
            global::G.DependabotAlertDependency dependency = default!,
            global::G.DependabotAlertSecurityAdvisory securityAdvisory = default!,
            global::G.DependabotAlertSecurityVulnerability securityVulnerability = default!,
            string url = default!,
            string htmlUrl = default!,
            global::System.DateTime createdAt = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.DismissedBy = dismissedBy ?? throw new global::System.ArgumentNullException(nameof(dismissedBy));
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment ?? throw new global::System.ArgumentNullException(nameof(dismissedComment));
            this.Number = number;
            this.State = state;
            this.Dependency = dependency;
            this.SecurityAdvisory = securityAdvisory;
            this.SecurityVulnerability = securityVulnerability;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DismissedAt = dismissedAt;
            this.FixedAt = fixedAt;
            this.AutoDismissedAt = autoDismissedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlert" /> class.
        /// </summary>
        public DependabotAlert()
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
        public static global::G.DependabotAlert? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.DependabotAlert>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.DependabotAlert?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.DependabotAlert?>(serializer.Deserialize<global::G.DependabotAlert>(jsonReader));
        }

    }
}