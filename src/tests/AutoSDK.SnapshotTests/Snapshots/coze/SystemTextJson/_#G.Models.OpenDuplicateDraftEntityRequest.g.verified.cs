//HintName: G.Models.OpenDuplicateDraftEntityRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenDuplicateDraftEntityRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TaskEntityTypeJsonConverter))]
        public global::G.TaskEntityType? EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_workspace_id")]
        public string? ToWorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityRequest" /> class.
        /// </summary>
        /// <param name="entityId"></param>
        /// <param name="entityType"></param>
        /// <param name="toWorkspaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenDuplicateDraftEntityRequest(
            string? entityId,
            global::G.TaskEntityType? entityType,
            string? toWorkspaceId)
        {
            this.EntityId = entityId;
            this.EntityType = entityType;
            this.ToWorkspaceId = toWorkspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityRequest" /> class.
        /// </summary>
        public OpenDuplicateDraftEntityRequest()
        {
        }
    }
}