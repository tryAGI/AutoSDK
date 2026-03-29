//HintName: G.Models.Compliance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Compliance
    {
        /// <summary>
        /// This is the recording consent of the call. Configure in `assistant.compliancePlan.recordingConsentPlan`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingConsent")]
        public global::G.RecordingConsent? RecordingConsent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Compliance" /> class.
        /// </summary>
        /// <param name="recordingConsent">
        /// This is the recording consent of the call. Configure in `assistant.compliancePlan.recordingConsentPlan`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Compliance(
            global::G.RecordingConsent? recordingConsent)
        {
            this.RecordingConsent = recordingConsent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Compliance" /> class.
        /// </summary>
        public Compliance()
        {
        }
    }
}