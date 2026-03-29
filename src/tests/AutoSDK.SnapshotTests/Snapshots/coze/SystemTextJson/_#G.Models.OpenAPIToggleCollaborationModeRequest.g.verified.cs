//HintName: G.Models.OpenAPIToggleCollaborationModeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIToggleCollaborationModeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaboration_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeJsonConverter))]
        public global::G.OpenAPIToggleCollaborationModeRequestCollaborationMode? CollaborationMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIToggleCollaborationModeRequest" /> class.
        /// </summary>
        /// <param name="collaborationMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIToggleCollaborationModeRequest(
            global::G.OpenAPIToggleCollaborationModeRequestCollaborationMode? collaborationMode)
        {
            this.CollaborationMode = collaborationMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIToggleCollaborationModeRequest" /> class.
        /// </summary>
        public OpenAPIToggleCollaborationModeRequest()
        {
        }
    }
}