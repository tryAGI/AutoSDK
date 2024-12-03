//HintName: G.Models.TranscriptRedactPiiPolicies.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
    /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
    /// </summary>
    public sealed partial class TranscriptRedactPiiPolicies
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptRedactPiiPolicies" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptRedactPiiPolicies(
 )
        {
        }
    }
}