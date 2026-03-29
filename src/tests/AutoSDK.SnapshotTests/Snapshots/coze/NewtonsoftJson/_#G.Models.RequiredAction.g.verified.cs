//HintName: G.Models.RequiredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequiredAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("submit_tool_outputs")]
        public global::G.SubmitToolOutputs? SubmitToolOutputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAction" /> class.
        /// </summary>
        /// <param name="submitToolOutputs"></param>
        /// <param name="type"></param>
        public RequiredAction(
            global::G.SubmitToolOutputs? submitToolOutputs,
            string? type)
        {
            this.SubmitToolOutputs = submitToolOutputs;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAction" /> class.
        /// </summary>
        public RequiredAction()
        {
        }
    }
}