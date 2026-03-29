//HintName: G.Models.ChatInputParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatInputParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.InputMessage>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ChatData? Data { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatInputParams" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="data"></param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
        public ChatInputParams(
            global::System.Collections.Generic.IList<global::G.InputMessage>? messages,
            global::G.ChatData? data,
            string? className)
        {
            this.Messages = messages;
            this.Data = data;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatInputParams" /> class.
        /// </summary>
        public ChatInputParams()
        {
        }
    }
}