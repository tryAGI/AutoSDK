//HintName: G.Models.CreateMessageRequestAttachment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageRequestAttachment
    {
        /// <summary>
        /// The ID of the file to attach to the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The tools to add this file to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsItem3>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestAttachment" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to attach to the message.
        /// </param>
        /// <param name="tools">
        /// The tools to add this file to.
        /// </param>
        public CreateMessageRequestAttachment(
            string? fileId,
            global::System.Collections.Generic.IList<global::G.ToolsItem3>? tools)
        {
            this.FileId = fileId;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequestAttachment" /> class.
        /// </summary>
        public CreateMessageRequestAttachment()
        {
        }
    }
}