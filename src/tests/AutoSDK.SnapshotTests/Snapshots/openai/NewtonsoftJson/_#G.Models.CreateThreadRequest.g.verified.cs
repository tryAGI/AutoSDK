﻿//HintName: G.Models.CreateThreadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options to create a new thread. If no thread is provided when running a <br/>
    /// request, an empty thread will be created.
    /// </summary>
    public sealed partial class CreateThreadRequest
    {
        /// <summary>
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? Messages { get; set; }

        /// <summary>
        /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_resources")]
        public global::G.CreateThreadRequestToolResources? ToolResources { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        public CreateThreadRequest(
            global::System.Collections.Generic.IList<global::G.CreateMessageRequest>? messages,
            global::G.CreateThreadRequestToolResources? toolResources,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
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