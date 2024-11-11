//HintName: G.Models.TriggerNamespacePipelineWithStreamBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineWithStreamRequest represents a request to trigger a user-owned<br/>
    /// pipeline synchronously and streams back the results.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineWithStreamBody
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
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineWithStreamBody" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        public TriggerNamespacePipelineWithStreamBody(
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData>? data)
        {
            this.Inputs = inputs;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineWithStreamBody" /> class.
        /// </summary>
        public TriggerNamespacePipelineWithStreamBody()
        {
        }
    }
}