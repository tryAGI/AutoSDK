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
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter))]
        public global::G.CreateNewExperimentHypothesisRequestStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerKeyId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderKeyId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptVersion", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experimentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewExperimentHypothesisRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="experimentId"></param>
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