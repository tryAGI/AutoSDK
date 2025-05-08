//HintName: G.Models.CreateResponseVariant3.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseVariant3
    {
        /// <summary>
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Image inputs](/docs/guides/images)<br/>
        /// - [File inputs](/docs/guides/pdf-files)<br/>
        /// - [Conversation state](/docs/guides/conversation-state)<br/>
        /// - [Function calling](/docs/guides/function-calling)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.InputItem>> Input { get; set; } = default!;

        /// <summary>
        /// Specify additional output data to include in the model response. Currently<br/>
        /// supported values are:<br/>
        /// - `file_search_call.results`: Include the search results of<br/>
        ///   the file search tool call.<br/>
        /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
        /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::System.Collections.Generic.IList<global::G.Includable>? Include { get; set; }

        /// <summary>
        /// Whether to allow the model to run tool calls in parallel.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// Whether to store the generated model response for later retrieval via<br/>
        /// API.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store")]
        public bool? Store { get; set; }

        /// <summary>
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        /// <param name="input">
        /// Text, image, or file inputs to the model, used to generate a response.<br/>
        /// Learn more:<br/>
        /// - [Text inputs and outputs](/docs/guides/text)<br/>
        /// - [Image inputs](/docs/guides/images)<br/>
        /// - [File inputs](/docs/guides/pdf-files)<br/>
        /// - [Conversation state](/docs/guides/conversation-state)<br/>
        /// - [Function calling](/docs/guides/function-calling)
        /// </param>
        /// <param name="include">
        /// Specify additional output data to include in the model response. Currently<br/>
        /// supported values are:<br/>
        /// - `file_search_call.results`: Include the search results of<br/>
        ///   the file search tool call.<br/>
        /// - `message.input_image.image_url`: Include image urls from the input message.<br/>
        /// - `computer_call_output.output.image_url`: Include image urls from the computer call output.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to allow the model to run tool calls in parallel.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="store">
        /// Whether to store the generated model response for later retrieval via<br/>
        /// API.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="stream">
        /// If set to true, the model response data will be streamed to the client<br/>
        /// as it is generated using [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format).<br/>
        /// See the [Streaming section below](/docs/api-reference/responses-streaming)<br/>
        /// for more information.<br/>
        /// Default Value: false
        /// </param>
        public CreateResponseVariant3(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.InputItem>> input,
            global::System.Collections.Generic.IList<global::G.Includable>? include,
            bool? parallelToolCalls,
            bool? store,
            bool? stream)
        {
            this.Input = input;
            this.Include = include;
            this.ParallelToolCalls = parallelToolCalls;
            this.Store = store;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseVariant3" /> class.
        /// </summary>
        public CreateResponseVariant3()
        {
        }
    }
}