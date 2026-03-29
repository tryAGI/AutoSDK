//HintName: G.Models.CreateNewExperimentHypothesisRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNewExperimentHypothesisRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateNewExperimentHypothesisRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderKeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewExperimentHypothesisRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="experimentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateNewExperimentHypothesisRequest(
            global::G.CreateNewExperimentHypothesisRequestStatus status,
            string providerKeyId,
            string promptVersion,
            string model,
            string experimentId)
        {
            this.Status = status;
            this.ProviderKeyId = providerKeyId ?? throw new global::System.ArgumentNullException(nameof(providerKeyId));
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewExperimentHypothesisRequest" /> class.
        /// </summary>
        public CreateNewExperimentHypothesisRequest()
        {
        }
    }
}