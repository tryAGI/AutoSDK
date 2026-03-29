//HintName: G.Models.DeleteAttachmentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAttachmentsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> FileNames { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteAttachmentsRequestEntityType EntityType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid EntityId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ContainerId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAttachmentsRequest" /> class.
        /// </summary>
        /// <param name="fileNames"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="containerId"></param>
        public DeleteAttachmentsRequest(
            global::System.Collections.Generic.IList<string> fileNames,
            global::G.DeleteAttachmentsRequestEntityType entityType,
            global::System.Guid entityId,
            global::System.Guid containerId)
        {
            this.FileNames = fileNames ?? throw new global::System.ArgumentNullException(nameof(fileNames));
            this.EntityType = entityType;
            this.EntityId = entityId;
            this.ContainerId = containerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAttachmentsRequest" /> class.
        /// </summary>
        public DeleteAttachmentsRequest()
        {
        }
    }
}