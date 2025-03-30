//HintName: G.Models.HumanMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Message from a human.<br/>
    /// HumanMessages are messages that are passed in from a human to the model.<br/>
    /// Example:<br/>
    ///     .. code-block:: python<br/>
    ///         from langchain_core.messages import HumanMessage, SystemMessage<br/>
    ///         messages = [<br/>
    ///             SystemMessage(<br/>
    ///                 content="You are a helpful assistant! Your name is Bob."<br/>
    ///             ),<br/>
    ///             HumanMessage(<br/>
    ///                 content="What is your name?"<br/>
    ///             )<br/>
    ///         ]<br/>
    ///         # Instantiate a chat model and invoke it with the messages<br/>
    ///         model = ...<br/>
    ///         print(model.invoke(messages))
    /// </summary>
    public sealed partial class HumanMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_metadata")]
        public object? ResponseMetadata { get; set; }

        /// <summary>
        /// Default Value: human
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HumanMessageTypeJsonConverter))]
        public global::G.HumanMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example")]
        public bool? Example { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: human
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="example">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HumanMessage(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            object? additionalKwargs,
            object? responseMetadata,
            global::G.HumanMessageType? type,
            string? name,
            string? id,
            bool? example)
        {
            this.Content = content;
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Example = example;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanMessage" /> class.
        /// </summary>
        public HumanMessage()
        {
        }
    }
}