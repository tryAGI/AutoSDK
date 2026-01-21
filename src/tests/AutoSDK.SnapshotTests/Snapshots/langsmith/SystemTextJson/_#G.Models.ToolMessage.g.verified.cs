//HintName: G.Models.ToolMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Message for passing the result of executing a tool back to a model.<br/>
    /// ToolMessages contain the result of a tool invocation. Typically, the result<br/>
    /// is encoded inside the `content` field.<br/>
    /// Example: A ToolMessage representing a result of 42 from a tool call with id<br/>
    ///     .. code-block:: python<br/>
    ///         from langchain_core.messages import ToolMessage<br/>
    ///         ToolMessage(content='42', tool_call_id='call_Jja7J89XsjrOLA5r!MEOW!SL')<br/>
    /// Example: A ToolMessage where only part of the tool output is sent to the model<br/>
    ///     and the full output is passed in to artifact.<br/>
    ///     .. versionadded:: 0.2.17<br/>
    ///     .. code-block:: python<br/>
    ///         from langchain_core.messages import ToolMessage<br/>
    ///         tool_output = {<br/>
    ///             "stdout": "From the graph we can see that the correlation between x and y is ...",<br/>
    ///             "stderr": None,<br/>
    ///             "artifacts": {"type": "image", "base64_data": "/9j/4gIcSU..."},<br/>
    ///         }<br/>
    ///         ToolMessage(<br/>
    ///             content=tool_output["stdout"],<br/>
    ///             artifact=tool_output,<br/>
    ///             tool_call_id='call_Jja7J89XsjrOLA5r!MEOW!SL',<br/>
    ///         )<br/>
    /// The tool_call_id field is used to associate the tool call request with the<br/>
    /// tool call response. This is useful in situations where a chat model is able<br/>
    /// to request multiple tool calls in parallel.
    /// </summary>
    public sealed partial class ToolMessage
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
        /// Default Value: tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public object? Artifact { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolMessageStatusJsonConverter))]
        public global::G.ToolMessageStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="additionalKwargs"></param>
        /// <param name="responseMetadata"></param>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toolCallId"></param>
        /// <param name="artifact"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMessage(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<string, object>>> content,
            string toolCallId,
            object? additionalKwargs,
            object? responseMetadata,
            string? type,
            string? name,
            string? id,
            object? artifact,
            global::G.ToolMessageStatus? status)
        {
            this.Content = content;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.AdditionalKwargs = additionalKwargs;
            this.ResponseMetadata = responseMetadata;
            this.Type = type;
            this.Name = name;
            this.Id = id;
            this.Artifact = artifact;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMessage" /> class.
        /// </summary>
        public ToolMessage()
        {
        }
    }
}