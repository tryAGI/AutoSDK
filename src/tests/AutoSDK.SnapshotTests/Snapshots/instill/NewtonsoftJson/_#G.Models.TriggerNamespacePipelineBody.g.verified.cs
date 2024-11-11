//HintName: G.Models.TriggerNamespacePipelineBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TriggerNamespacePipelineRequest represents a request to trigger a user-owned<br/>
    /// pipeline synchronously.
    /// </summary>
    public sealed partial class TriggerNamespacePipelineBody
    {
        /// <summary>
        /// Pipeline input parameters, it will be deprecated soon.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TriggerData> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineBody" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Pipeline input parameters, it will be deprecated soon.
        /// </param>
        /// <param name="data"></param>
        public TriggerNamespacePipelineBody(
            global::System.Collections.Generic.IList<object> inputs,
            global::System.Collections.Generic.IList<global::G.TriggerData> data)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerNamespacePipelineBody" /> class.
        /// </summary>
        public TriggerNamespacePipelineBody()
        {
        }
    }
}