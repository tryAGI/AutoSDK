//HintName: G.Models.ToolMessageFailed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMessageFailed
    {
        /// <summary>
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::System.Collections.Generic.IList<global::G.TextContent>? Contents { get; set; }

        /// <summary>
        /// This message is triggered when the tool call fails.<br/>
        /// This message is never triggered for async tool calls.<br/>
        /// If this message is not provided, the model will be requested to respond.<br/>
        /// If this message is provided, only this message will be spoken and the model will not be requested to come up with a response. It's an exclusive OR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolMessageFailedTypeJsonConverter))]
        public global::G.ToolMessageFailedType Type { get; set; }

        /// <summary>
        /// This is an optional boolean that if true, the call will end after the message is spoken. Default is false.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCallAfterSpokenEnabled")]
        public bool? EndCallAfterSpokenEnabled { get; set; }

        /// <summary>
        /// This is the content that the assistant says when this message is triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::G.Condition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageFailed" /> class.
        /// </summary>
        /// <param name="contents">
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </param>
        /// <param name="type">
        /// This message is triggered when the tool call fails.<br/>
        /// This message is never triggered for async tool calls.<br/>
        /// If this message is not provided, the model will be requested to respond.<br/>
        /// If this message is provided, only this message will be spoken and the model will not be requested to come up with a response. It's an exclusive OR.
        /// </param>
        /// <param name="endCallAfterSpokenEnabled">
        /// This is an optional boolean that if true, the call will end after the message is spoken. Default is false.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="content">
        /// This is the content that the assistant says when this message is triggered.
        /// </param>
        /// <param name="conditions">
        /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMessageFailed(
            global::System.Collections.Generic.IList<global::G.TextContent>? contents,
            global::G.ToolMessageFailedType type,
            bool? endCallAfterSpokenEnabled,
            string? content,
            global::System.Collections.Generic.IList<global::G.Condition>? conditions)
        {
            this.Contents = contents;
            this.Type = type;
            this.EndCallAfterSpokenEnabled = endCallAfterSpokenEnabled;
            this.Content = content;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessageFailed" /> class.
        /// </summary>
        public ToolMessageFailed()
        {
        }
    }
}