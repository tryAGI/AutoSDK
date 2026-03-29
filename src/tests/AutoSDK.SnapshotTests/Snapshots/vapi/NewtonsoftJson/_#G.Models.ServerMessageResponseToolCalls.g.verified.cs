//HintName: G.Models.ServerMessageResponseToolCalls.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageResponseToolCalls
    {
        /// <summary>
        /// These are the results of the "tool-calls" message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::System.Collections.Generic.IList<global::G.ToolCallResult>? Results { get; set; }

        /// <summary>
        /// This is the error message if the tool call was not successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseToolCalls" /> class.
        /// </summary>
        /// <param name="results">
        /// These are the results of the "tool-calls" message.
        /// </param>
        /// <param name="error">
        /// This is the error message if the tool call was not successful.
        /// </param>
        public ServerMessageResponseToolCalls(
            global::System.Collections.Generic.IList<global::G.ToolCallResult>? results,
            string? error)
        {
            this.Results = results;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageResponseToolCalls" /> class.
        /// </summary>
        public ServerMessageResponseToolCalls()
        {
        }
    }
}