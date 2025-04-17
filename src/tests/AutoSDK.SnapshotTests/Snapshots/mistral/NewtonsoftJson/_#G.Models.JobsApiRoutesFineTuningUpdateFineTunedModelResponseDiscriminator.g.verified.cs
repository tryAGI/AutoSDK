//HintName: G.Models.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? ModelType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="modelType"></param>
        public JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator(
            global::G.JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminatorModelType? modelType)
        {
            this.ModelType = modelType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator" /> class.
        /// </summary>
        public JobsApiRoutesFineTuningUpdateFineTunedModelResponseDiscriminator()
        {
        }
    }
}