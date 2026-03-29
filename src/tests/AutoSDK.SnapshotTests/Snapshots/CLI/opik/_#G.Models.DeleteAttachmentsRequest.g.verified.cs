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
        [global::System.Text.Json.Serialization.JsonPropertyName("file_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FileNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeleteAttachmentsRequestEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteAttachmentsRequestEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAttachmentsRequest" /> class.
        /// </summary>
        /// <param name="fileNames"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="containerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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