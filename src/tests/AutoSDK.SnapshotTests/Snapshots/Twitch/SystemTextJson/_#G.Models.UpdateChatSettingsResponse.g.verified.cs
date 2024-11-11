//HintName: G.Models.UpdateChatSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateChatSettingsResponse
    {
        /// <summary>
        /// The list of chat settings. The list contains a single object with all the settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatSettingsUpdated> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatSettingsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of chat settings. The list contains a single object with all the settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpdateChatSettingsResponse(
            global::System.Collections.Generic.IList<global::G.ChatSettingsUpdated> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChatSettingsResponse" /> class.
        /// </summary>
        public UpdateChatSettingsResponse()
        {
        }
    }
}