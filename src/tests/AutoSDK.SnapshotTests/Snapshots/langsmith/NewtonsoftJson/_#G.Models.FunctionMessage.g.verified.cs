//HintName: G.Models.FunctionMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Message for passing the result of executing a tool back to a model.<br/>
    /// FunctionMessage are an older version of the ToolMessage schema, and<br/>
    /// do not contain the tool_call_id field.<br/>
    /// The tool_call_id field is used to associate the tool call request with the<br/>
    /// tool call response. This is useful in situations where a chat model is able<br/>
    /// to request multiple tool calls in parallel.
    /// </summary>
    public sealed partial class FunctionMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: function
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public FunctionMessage(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            string name,
            object? additionalKwargs,
            object? responseMetadata,
            global::G.FunctionMessageType? type,
            string? id)
        {
            this.Content = content;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionMessage" /> class.
        /// </summary>
        public FunctionMessage()
        {
        }
    }
}