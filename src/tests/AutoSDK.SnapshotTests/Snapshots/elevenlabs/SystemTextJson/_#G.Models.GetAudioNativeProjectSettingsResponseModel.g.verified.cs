//HintName: G.Models.GetAudioNativeProjectSettingsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"enabled":true,"settings":{"audio_path":"audio/my_project.mp3","audio_url":"https://example.com/audio/my_project.mp3","author":"John Doe","background_color":"#FFFFFF","image":"https://example.com/image.jpg","sessionization":1,"small":false,"status":"ready","text_color":"#000000","title":"My Project"},"snapshot_id":"JBFqnCBsd6RMkjVDRZzb"}
    /// </summary>
    public sealed partial class GetAudioNativeProjectSettingsResponseModel
    {
        /// <summary>
        /// Whether the project is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// The ID of the latest snapshot of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// The settings of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::G.AudioNativeProjectSettingsResponseModel? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether the project is enabled.
        /// </param>
        /// <param name="snapshotId">
        /// The ID of the latest snapshot of the project.
        /// </param>
        /// <param name="settings">
        /// The settings of the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAudioNativeProjectSettingsResponseModel(
            bool enabled,
            string? snapshotId,
            global::G.AudioNativeProjectSettingsResponseModel? settings)
        {
            this.Enabled = enabled;
            this.SnapshotId = snapshotId;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAudioNativeProjectSettingsResponseModel" /> class.
        /// </summary>
        public GetAudioNativeProjectSettingsResponseModel()
        {
        }
    }
}