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
        /// The type of tool<br/>
        /// Default Value: client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClientToolConfigInputTypeJsonConverter))]
        public global::G.ClientToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for a response from the client. Should only be set if expects_response is true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: client
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="expectsResponse">
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for a response from the client. Should only be set if expects_response is true
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolConfigInput(
            string name,
            string description,
            global::G.ClientToolConfigInputType? type,
            global::G.ObjectJsonSchemaPropertyInput? parameters,
            bool? expectsResponse,
            int? responseTimeoutSecs,
            global::G.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Parameters = parameters;
            this.ExpectsResponse = expectsResponse;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
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