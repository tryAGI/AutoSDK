//HintName: G.Models.TriggerNamespacePipelineReleaseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineReleaseRequest represents a request to trigger a pinned<br/>
    /// release of a user-owned pipeline.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineReleaseBody
    {
        /// <summary>
        /// Pipeline input parameters, it will be deprecated soon.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.TriggerData>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineReleaseBody" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        public TriggerNamespacePipelineReleaseBody(
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData>? data)
        {
            this.Inputs = inputs;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineReleaseBody" /> class.
        /// </summary>
        public TriggerNamespacePipelineReleaseBody()
        {
        }
    }
}