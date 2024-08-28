//HintName: G.Models.LanguageStudioApiServerDataTypesChatChatRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageStudioApiServerDataTypesChatChatRequest
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ModelName Model { get; set; } = default!;

        /// <summary>
        /// messages
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.OneOf<global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.SystemMessage>> Messages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolDefinition>? Tools { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int N { get; set; } = 1;

        /// <summary>
        /// Default Value: 4096
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int MaxTokens { get; set; } = 4096;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double Temperature { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double TopP { get; set; } = 1;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop")]
        public global::System.AnyOf<string?, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether or not to stream the result one token at a time using<br/>
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events).<br/>
        /// This can be useful when waiting for long results where a long wait time for an<br/>
        /// answer can be problematic, such as a chatbot. If set to `True`, then `n` must<br/>
        /// be 1. A streaming response is different than the non-streaming response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool Stream { get; set; } = false;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mock_response")]
        public global::G.MockResponseConfig? MockResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents")]
        public global::System.Collections.Generic.IList<global::G.DocumentSchema>? Documents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public global::System.AllOf<global::G.ResponseFormat>? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}