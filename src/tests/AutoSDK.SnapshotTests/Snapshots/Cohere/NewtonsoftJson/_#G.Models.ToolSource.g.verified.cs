//HintName: G.Models.ToolSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSource
    {
        /// <summary>
        /// The unique identifier of the document
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_output")]
        public object? ToolOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the document
        /// </param>
        /// <param name="toolOutput"></param>
        public ToolSource(
            string? id,
            object? toolOutput)
        {
            this.Id = id;
            this.ToolOutput = toolOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSource" /> class.
        /// </summary>
        public ToolSource()
        {
        }
    }
}