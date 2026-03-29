//HintName: G.Models.SubmitToolOutputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitToolOutputs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.InterruptPlugin>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputs" /> class.
        /// </summary>
        /// <param name="toolCalls"></param>
        public SubmitToolOutputs(
            global::System.Collections.Generic.IList<global::G.InterruptPlugin>? toolCalls)
        {
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitToolOutputs" /> class.
        /// </summary>
        public SubmitToolOutputs()
        {
        }
    }
}