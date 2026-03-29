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
        [global::System.Text.Json.Serialization.JsonPropertyName("detector")]
        public string? Detector { get; set; }

        /// <summary>
        /// Whether this detector flagged the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        public bool? Flagged { get; set; }

        /// <summary>
        /// Confidence score from 0.0 to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Matched text spans or entities that triggered the detector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::G.DetectorMatch>? Matches { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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