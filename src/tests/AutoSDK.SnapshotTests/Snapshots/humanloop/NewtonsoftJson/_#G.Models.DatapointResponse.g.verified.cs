//HintName: G.Models.DatapointResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatapointResponse
    {
        /// <summary>
        /// Unique identifier for the datapoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public object? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatapointResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the datapoint.
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="target"></param>
        /// <param name="messages"></param>
        public DatapointResponse(
            string id,
            object? inputs,
            object? target,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs;
            this.Target = target;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatapointResponse" /> class.
        /// </summary>
        public DatapointResponse()
        {
        }
    }
}