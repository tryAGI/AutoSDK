//HintName: G.Models.MessageObjectAttachment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageObjectAttachment
    {
        /// <summary>
        /// The ID of the file to attach to the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The tools to add this file to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsItem6>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObjectAttachment" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file to attach to the message.
        /// </param>
        /// <param name="tools">
        /// The tools to add this file to.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageObjectAttachment(
            string? fileId,
            global::System.Collections.Generic.IList<global::G.ToolsItem6>? tools)
        {
            this.FileId = fileId;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObjectAttachment" /> class.
        /// </summary>
        public MessageObjectAttachment()
        {
        }
    }
}