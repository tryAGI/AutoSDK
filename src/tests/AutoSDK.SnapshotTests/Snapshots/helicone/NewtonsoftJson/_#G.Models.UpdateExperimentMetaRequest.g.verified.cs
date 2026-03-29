//HintName: G.Models.UpdateExperimentMetaRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateExperimentMetaRequest
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Meta { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="UpdateExperimentMetaRequest" /> class.
        /// </summary>
        /// <param name="meta">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        public UpdateExperimentMetaRequest(
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string experimentId)
        {
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExperimentMetaRequest" /> class.
        /// </summary>
        public UpdateExperimentMetaRequest()
        {
        }
    }
}