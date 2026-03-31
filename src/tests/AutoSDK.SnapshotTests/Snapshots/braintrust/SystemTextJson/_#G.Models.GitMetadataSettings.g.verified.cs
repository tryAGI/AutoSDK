//HintName: G.Models.GitMetadataSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional settings for collecting git metadata. By default, will collect all git metadata fields allowed in org-level settings.
    /// </summary>
    public sealed partial class GitMetadataSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collect")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GitMetadataSettingsCollectJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GitMetadataSettingsCollect Collect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::G.GitMetadataSettingsField>? Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitMetadataSettings" /> class.
        /// </summary>
        /// <param name="collect"></param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GitMetadataSettings(
            global::G.GitMetadataSettingsCollect collect,
            global::System.Collections.Generic.IList<global::G.GitMetadataSettingsField>? fields)
        {
            this.Collect = collect;
            this.Fields = fields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitMetadataSettings" /> class.
        /// </summary>
        public GitMetadataSettings()
        {
        }
    }
}