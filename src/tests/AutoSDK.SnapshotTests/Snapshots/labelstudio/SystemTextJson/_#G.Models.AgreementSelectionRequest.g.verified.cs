//HintName: G.Models.AgreementSelectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgreementSelectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotators")]
        public global::G.AgreementSelectionGroupRequest? Annotators { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ground_truth")]
        public bool? GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::G.AgreementSelectionGroupRequest? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementSelectionRequest" /> class.
        /// </summary>
        /// <param name="annotators"></param>
        /// <param name="groundTruth">
        /// Default Value: false
        /// </param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgreementSelectionRequest(
            global::G.AgreementSelectionGroupRequest? annotators,
            bool? groundTruth,
            global::G.AgreementSelectionGroupRequest? models)
        {
            this.Annotators = annotators;
            this.GroundTruth = groundTruth;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementSelectionRequest" /> class.
        /// </summary>
        public AgreementSelectionRequest()
        {
        }
    }
}