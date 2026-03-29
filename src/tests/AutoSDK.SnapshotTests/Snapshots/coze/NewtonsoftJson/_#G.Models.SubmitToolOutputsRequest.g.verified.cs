//HintName: G.Models.SubmitToolOutputsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_outputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolOutput> ToolOutputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRequest" /> class.
        /// </summary>
        /// <param name="toolOutputs"></param>
        /// <param name="stream"></param>
        public SubmitToolOutputsRequest(
            global::System.Collections.Generic.IList<global::G.ToolOutput> toolOutputs,
            bool? stream)
        {
            this.Stream = stream;
            this.ToolOutputs = toolOutputs ?? throw new global::System.ArgumentNullException(nameof(toolOutputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputsRequest" /> class.
        /// </summary>
        public SubmitToolOutputsRequest()
        {
        }
    }
}