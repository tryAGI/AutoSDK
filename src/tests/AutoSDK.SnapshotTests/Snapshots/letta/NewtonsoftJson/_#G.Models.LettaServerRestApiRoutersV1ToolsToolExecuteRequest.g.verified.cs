//HintName: G.Models.LettaServerRestApiRoutersV1ToolsToolExecuteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaServerRestApiRoutersV1ToolsToolExecuteRequest
    {
        /// <summary>
        /// Arguments to pass to the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args")]
        public object? Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ToolsToolExecuteRequest" /> class.
        /// </summary>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        public LettaServerRestApiRoutersV1ToolsToolExecuteRequest(
            object? args)
        {
            this.Args = args;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaServerRestApiRoutersV1ToolsToolExecuteRequest" /> class.
        /// </summary>
        public LettaServerRestApiRoutersV1ToolsToolExecuteRequest()
        {
        }
    }
}