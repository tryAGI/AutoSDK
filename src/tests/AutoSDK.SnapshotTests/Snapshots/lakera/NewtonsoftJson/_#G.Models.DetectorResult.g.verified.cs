//HintName: G.Models.DetectorResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectorResult
    {
        /// <summary>
        /// Name of the detector (e.g., prompt_injection, pii, jailbreak).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detector")]
        public string? Detector { get; set; }

        /// <summary>
        /// Whether this detector flagged the content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// Confidence score from 0.0 to 1.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Matched text spans or entities that triggered the detector.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matches")]
        public global::System.Collections.Generic.IList<global::G.DetectorMatch>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorResult" /> class.
        /// </summary>
        /// <param name="detector">
        /// Name of the detector (e.g., prompt_injection, pii, jailbreak).
        /// </param>
        /// <param name="flagged">
        /// Whether this detector flagged the content.
        /// </param>
        /// <param name="confidence">
        /// Confidence score from 0.0 to 1.0.
        /// </param>
        /// <param name="matches">
        /// Matched text spans or entities that triggered the detector.
        /// </param>
        public DetectorResult(
            string? detector,
            bool? flagged,
            double? confidence,
            global::System.Collections.Generic.IList<global::G.DetectorMatch>? matches)
        {
            this.Detector = detector;
            this.Flagged = flagged;
            this.Confidence = confidence;
            this.Matches = matches;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorResult" /> class.
        /// </summary>
        public DetectorResult()
        {
        }
    }
}