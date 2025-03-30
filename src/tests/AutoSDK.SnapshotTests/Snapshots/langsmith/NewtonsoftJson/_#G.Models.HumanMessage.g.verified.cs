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
        /// Default Value: human
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.HumanMessageType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example")]
        public bool? Example { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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