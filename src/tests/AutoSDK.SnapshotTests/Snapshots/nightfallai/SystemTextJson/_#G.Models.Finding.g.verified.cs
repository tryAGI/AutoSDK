//HintName: G.Models.Finding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Finding
    {
        /// <summary>
        /// The matched sensitive text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finding")]
        public string? Finding1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redactedFinding")]
        public string? RedactedFinding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeContext")]
        public string? BeforeContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterContext")]
        public string? AfterContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector")]
        public global::G.DetectorMetadata? Detector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfidenceJsonConverter))]
        public global::G.Confidence? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::G.FindingLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redactedLocation")]
        public global::G.FindingLocation? RedactedLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchedDetectionRuleUUIDs")]
        public global::System.Collections.Generic.IList<string>? MatchedDetectionRuleUUIDs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchedDetectionRules")]
        public global::System.Collections.Generic.IList<string>? MatchedDetectionRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("findingMetadata")]
        public global::G.FindingMetadata? FindingMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Finding" /> class.
        /// </summary>
        /// <param name="finding1">
        /// The matched sensitive text
        /// </param>
        /// <param name="redactedFinding"></param>
        /// <param name="beforeContext"></param>
        /// <param name="afterContext"></param>
        /// <param name="detector"></param>
        /// <param name="confidence"></param>
        /// <param name="location"></param>
        /// <param name="redactedLocation"></param>
        /// <param name="matchedDetectionRuleUUIDs"></param>
        /// <param name="matchedDetectionRules"></param>
        /// <param name="findingMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Finding(
            string? finding1,
            string? redactedFinding,
            string? beforeContext,
            string? afterContext,
            global::G.DetectorMetadata? detector,
            global::G.Confidence? confidence,
            global::G.FindingLocation? location,
            global::G.FindingLocation? redactedLocation,
            global::System.Collections.Generic.IList<string>? matchedDetectionRuleUUIDs,
            global::System.Collections.Generic.IList<string>? matchedDetectionRules,
            global::G.FindingMetadata? findingMetadata)
        {
            this.Finding1 = finding1;
            this.RedactedFinding = redactedFinding;
            this.BeforeContext = beforeContext;
            this.AfterContext = afterContext;
            this.Detector = detector;
            this.Confidence = confidence;
            this.Location = location;
            this.RedactedLocation = redactedLocation;
            this.MatchedDetectionRuleUUIDs = matchedDetectionRuleUUIDs;
            this.MatchedDetectionRules = matchedDetectionRules;
            this.FindingMetadata = findingMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Finding" /> class.
        /// </summary>
        public Finding()
        {
        }
    }
}