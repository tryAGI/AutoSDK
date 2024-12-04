//HintName: G.Models.CreateThreadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequest
    {
        /// <summary>
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? Messages { get; set; }

        /// <summary>
        /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_resources")]
        public global::G.CreateThreadRequestToolResources? ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </param>
        /// <param name="toolResources">
        /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateThreadRequest(
            global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? messages,
            global::G.CreateThreadRequestToolResources? toolResources,
            object? metadata)
        {
            this.Messages = messages;
            this.ToolResources = toolResources;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequest" /> class.
        /// </summary>
        public CreateThreadRequest()
        {
        }
    }
}