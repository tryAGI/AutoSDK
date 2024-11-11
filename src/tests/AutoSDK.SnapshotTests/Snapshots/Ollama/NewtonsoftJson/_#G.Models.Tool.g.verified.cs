//HintName: G.Models.Tool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool the model may call.
    /// </summary>
    public sealed partial class Tool
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolType? Type { get; set; }

        /// <summary>
        /// A function that the model may call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ToolFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.<br/>
        /// Default Value: function
        /// </param>
        /// <param name="function">
        /// A function that the model may call.
        /// </param>
        public Tool(
            global::G.ToolType? type,
            global::G.ToolFunction? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tool" /> class.
        /// </summary>
        public Tool()
        {
        }
    }
}