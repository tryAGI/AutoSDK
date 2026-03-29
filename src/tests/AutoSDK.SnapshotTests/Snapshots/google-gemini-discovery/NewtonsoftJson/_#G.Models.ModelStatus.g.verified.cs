//HintName: G.Models.ModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the underlying model. This is used to indicate the stage of the underlying model and the retirement time if applicable.
    /// </summary>
    public sealed partial class ModelStatus
    {
        /// <summary>
        /// The stage of the underlying model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelStage")]
        public global::G.ModelStatusModelStage? ModelStage { get; set; }

        /// <summary>
        /// The time at which the model will be retired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retirementTime")]
        public string? RetirementTime { get; set; }

        /// <summary>
        /// A message explaining the model status.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatus" /> class.
        /// </summary>
        /// <param name="modelStage">
        /// The stage of the underlying model.
        /// </param>
        /// <param name="retirementTime">
        /// The time at which the model will be retired.
        /// </param>
        /// <param name="message">
        /// A message explaining the model status.
        /// </param>
        public ModelStatus(
            global::G.ModelStatusModelStage? modelStage,
            string? retirementTime,
            string? message)
        {
            this.ModelStage = modelStage;
            this.RetirementTime = retirementTime;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelStatus" /> class.
        /// </summary>
        public ModelStatus()
        {
        }
    }
}