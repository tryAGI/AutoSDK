//HintName: G.Models.ClientToolConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A client tool is one that sends an event to the user's client to trigger something client side
    /// </summary>
    public sealed partial class ClientToolConfigInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 1 and 30 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// The type of tool<br/>
        /// Default Value: client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClientToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigInput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 1 and 30 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: client
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="expectsResponse">
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariables"></param>
        public ClientToolConfigInput(
            string name,
            string description,
            string? id,
            int? responseTimeoutSecs,
            global::G.ClientToolConfigInputType? type,
            global::G.ObjectJsonSchemaPropertyInput? parameters,
            bool? expectsResponse,
            global::G.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
            this.Parameters = parameters;
            this.ExpectsResponse = expectsResponse;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigInput" /> class.
        /// </summary>
        public ClientToolConfigInput()
        {
        }
    }
}