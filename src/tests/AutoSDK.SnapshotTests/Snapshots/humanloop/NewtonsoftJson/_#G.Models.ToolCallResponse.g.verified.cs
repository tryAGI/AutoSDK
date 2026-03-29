//HintName: G.Models.ToolCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallResponse
    {
        /// <summary>
        /// Unique identifier for the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Type of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function")]
        public global::G.ToolCallResponseFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the tool call.
        /// </param>
        /// <param name="type">
        /// Type of the tool call.
        /// </param>
        /// <param name="function"></param>
        public ToolCallResponse(
            string id,
            string type,
            global::G.ToolCallResponseFunction? function)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResponse" /> class.
        /// </summary>
        public ToolCallResponse()
        {
        }
    }
}