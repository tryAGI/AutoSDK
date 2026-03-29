//HintName: G.Models.UpsertExperimentEvaluationResponseBodyData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertExperimentEvaluationResponseBodyData
    {
        /// <summary>
        /// The ID of the upserted experiment evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertExperimentEvaluationResponseBodyData" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the upserted experiment evaluation
        /// </param>
        public UpsertExperimentEvaluationResponseBodyData(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertExperimentEvaluationResponseBodyData" /> class.
        /// </summary>
        public UpsertExperimentEvaluationResponseBodyData()
        {
        }
    }
}