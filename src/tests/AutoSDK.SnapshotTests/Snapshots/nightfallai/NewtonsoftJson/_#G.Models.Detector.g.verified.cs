//HintName: G.Models.Detector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Detector
    {
        /// <summary>
        /// UUID of a pre-configured detector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectorUUID")]
        public string? DetectorUUID { get; set; }

        /// <summary>
        /// Minimum number of findings required<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minNumFindings")]
        public int? MinNumFindings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minConfidence", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Confidence MinConfidence { get; set; } = default!;

        /// <summary>
        /// Display name for the detector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectorType", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DetectorType DetectorType { get; set; } = default!;

        /// <summary>
        /// Name of a built-in Nightfall detector (e.g., CREDIT_CARD_NUMBER,<br/>
        /// US_SOCIAL_SECURITY_NUMBER, API_KEY, EMAIL_ADDRESS, PHONE_NUMBER,<br/>
        /// IP_ADDRESS, PERSON_NAME)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nightfallDetector")]
        public string? NightfallDetector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex")]
        public global::G.Regex? Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordList")]
        public global::G.WordList? WordList { get; set; }

        /// <summary>
        /// Rules for adjusting confidence based on context
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contextRules")]
        public global::System.Collections.Generic.IList<global::G.ContextRule>? ContextRules { get; set; }

        /// <summary>
        /// Rules for excluding certain matches
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclusionRules")]
        public global::System.Collections.Generic.IList<global::G.ExclusionRule>? ExclusionRules { get; set; }

        /// <summary>
        /// How findings should be redacted (specify exactly one type)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redactionConfig")]
        public global::G.RedactionConfig? RedactionConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Detector" /> class.
        /// </summary>
        /// <param name="minConfidence"></param>
        /// <param name="detectorType"></param>
        /// <param name="detectorUUID">
        /// UUID of a pre-configured detector
        /// </param>
        /// <param name="minNumFindings">
        /// Minimum number of findings required<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="displayName">
        /// Display name for the detector
        /// </param>
        /// <param name="nightfallDetector">
        /// Name of a built-in Nightfall detector (e.g., CREDIT_CARD_NUMBER,<br/>
        /// US_SOCIAL_SECURITY_NUMBER, API_KEY, EMAIL_ADDRESS, PHONE_NUMBER,<br/>
        /// IP_ADDRESS, PERSON_NAME)
        /// </param>
        /// <param name="regex"></param>
        /// <param name="wordList"></param>
        /// <param name="contextRules">
        /// Rules for adjusting confidence based on context
        /// </param>
        /// <param name="exclusionRules">
        /// Rules for excluding certain matches
        /// </param>
        /// <param name="redactionConfig">
        /// How findings should be redacted (specify exactly one type)
        /// </param>
        public Detector(
            global::G.Confidence minConfidence,
            global::G.DetectorType detectorType,
            string? detectorUUID,
            int? minNumFindings,
            string? displayName,
            string? nightfallDetector,
            global::G.Regex? regex,
            global::G.WordList? wordList,
            global::System.Collections.Generic.IList<global::G.ContextRule>? contextRules,
            global::System.Collections.Generic.IList<global::G.ExclusionRule>? exclusionRules,
            global::G.RedactionConfig? redactionConfig)
        {
            this.DetectorUUID = detectorUUID;
            this.MinNumFindings = minNumFindings;
            this.MinConfidence = minConfidence;
            this.DisplayName = displayName;
            this.DetectorType = detectorType;
            this.NightfallDetector = nightfallDetector;
            this.Regex = regex;
            this.WordList = wordList;
            this.ContextRules = contextRules;
            this.ExclusionRules = exclusionRules;
            this.RedactionConfig = redactionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Detector" /> class.
        /// </summary>
        public Detector()
        {
        }
    }
}