//HintName: G.Models.ToolMessageDelayed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMessageDelayed
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
        /// This message is triggered when the tool call is delayed.<br/>
        /// There are the two things that can trigger this message:<br/>
        /// 1. The user talks with the assistant while your server is processing the request. Default is "Sorry, a few more seconds."<br/>
        /// 2. The server doesn't respond within `timingMilliseconds`.<br/>
        /// This message is never triggered for async tool calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolMessageDelayedType Type { get; set; }

        /// <summary>
        /// The number of milliseconds to wait for the server response before saying this message.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::Newtonsoft.Json.JsonProperty("timingMilliseconds")]
        public double? TimingMilliseconds { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolMessageDelayed" /> class.
        /// </summary>
        /// <param name="contents">
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </param>
        /// <param name="type">
        /// This message is triggered when the tool call is delayed.<br/>
        /// There are the two things that can trigger this message:<br/>
        /// 1. The user talks with the assistant while your server is processing the request. Default is "Sorry, a few more seconds."<br/>
        /// 2. The server doesn't respond within `timingMilliseconds`.<br/>
        /// This message is never triggered for async tool calls.
        /// </param>
        /// <param name="timingMilliseconds">
        /// The number of milliseconds to wait for the server response before saying this message.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="content">
        /// This is the content that the assistant says when this message is triggered.
        /// </param>
        /// <param name="conditions">
        /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
        /// </param>
        public ToolMessageDelayed(
            global::System.Collections.Generic.IList<global::G.TextContent>? contents,
            global::G.ToolMessageDelayedType type,
            double? timingMilliseconds,
            string? content,
            global::System.Collections.Generic.IList<global::G.Condition>? conditions)
        {
            this.Contents = contents;
            this.Type = type;
            this.TimingMilliseconds = timingMilliseconds;
            this.Content = content;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageDelayed" /> class.
        /// </summary>
        public ToolMessageDelayed()
        {
        }
    }
}