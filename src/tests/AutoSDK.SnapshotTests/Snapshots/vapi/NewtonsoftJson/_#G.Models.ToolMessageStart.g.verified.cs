//HintName: G.Models.ToolMessageStart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMessageStart
    {
        /// <summary>
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.TextContent>? Contents { get; set; }

        /// <summary>
        /// This message is triggered when the tool call starts.<br/>
        /// This message is never triggered for async tools.<br/>
        /// If this message is not provided, one of the default filler messages "Hold on a sec", "One moment", "Just a sec", "Give me a moment" or "This'll just take a sec" will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolMessageStartTypeJsonConverter))]
        public global::G.ToolMessageStartType Type { get; set; }

        /// <summary>
        /// This is an optional boolean that if true, the tool call will only trigger after the message is spoken. Default is false.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("blocking")]
        public bool? Blocking { get; set; }

        /// <summary>
        /// This is the content that the assistant says when this message is triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions")]
        public global::System.Collections.Generic.IList<global::G.Condition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageStart" /> class.
        /// </summary>
        /// <param name="contents">
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </param>
        /// <param name="type">
        /// This message is triggered when the tool call starts.<br/>
        /// This message is never triggered for async tools.<br/>
        /// If this message is not provided, one of the default filler messages "Hold on a sec", "One moment", "Just a sec", "Give me a moment" or "This'll just take a sec" will be used.
        /// </param>
        /// <param name="blocking">
        /// This is an optional boolean that if true, the tool call will only trigger after the message is spoken. Default is false.<br/>
        /// @default false<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="content">
        /// This is the content that the assistant says when this message is triggered.
        /// </param>
        /// <param name="conditions">
        /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
        /// </param>
        public ToolMessageStart(
            global::System.Collections.Generic.IList<global::G.TextContent>? contents,
            global::G.ToolMessageStartType type,
            bool? blocking,
            string? content,
            global::System.Collections.Generic.IList<global::G.Condition>? conditions)
        {
            this.Contents = contents;
            this.Type = type;
            this.Blocking = blocking;
            this.Content = content;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageStart" /> class.
        /// </summary>
        public ToolMessageStart()
        {
        }
    }
}