//HintName: G.Models.UpdateSessionDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSessionDTO
    {
        /// <summary>
        /// This is the new name for the session. Maximum length is 40 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the new status for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateSessionDTOStatusJsonConverter))]
        public global::G.UpdateSessionDTOStatus? Status { get; set; }

        /// <summary>
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationSeconds")]
        public double? ExpirationSeconds { get; set; }

        /// <summary>
        /// This is the updated array of chat messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the new name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the new status for the session.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="messages">
        /// This is the updated array of chat messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSessionDTO(
            string? name,
            global::G.UpdateSessionDTOStatus? status,
            double? expirationSeconds,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SystemMessage, global::G.UserMessage, global::G.AssistantMessage, global::G.ToolMessage, global::G.DeveloperMessage>>? messages)
        {
            this.Name = name;
            this.Status = status;
            this.ExpirationSeconds = expirationSeconds;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSessionDTO" /> class.
        /// </summary>
        public UpdateSessionDTO()
        {
        }
    }
}