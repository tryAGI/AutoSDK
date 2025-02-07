//HintName: G.Models.ModifyChannelInformationBodyContentClassificationLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModifyChannelInformationBodyContentClassificationLabel
    {
        /// <summary>
        /// ID of the [Content Classification Labels](https://blog.twitch.tv/en/2023/06/20/introducing-content-classification-labels/) that must be added/removed from the channel. Can be one of the following values:  <br/>
        ///   <br/>
        /// * DrugsIntoxication<br/>
        /// * SexualThemes<br/>
        /// * ViolentGraphic<br/>
        /// * Gambling<br/>
        /// * ProfanityVulgarity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModifyChannelInformationBodyContentClassificationLabelIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModifyChannelInformationBodyContentClassificationLabelId Id { get; set; }

        /// <summary>
        /// Boolean flag indicating whether the label should be enabled (true) or disabled for the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelInformationBodyContentClassificationLabel" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the [Content Classification Labels](https://blog.twitch.tv/en/2023/06/20/introducing-content-classification-labels/) that must be added/removed from the channel. Can be one of the following values:  <br/>
        ///   <br/>
        /// * DrugsIntoxication<br/>
        /// * SexualThemes<br/>
        /// * ViolentGraphic<br/>
        /// * Gambling<br/>
        /// * ProfanityVulgarity
        /// </param>
        /// <param name="isEnabled">
        /// Boolean flag indicating whether the label should be enabled (true) or disabled for the channel.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModifyChannelInformationBodyContentClassificationLabel(
            global::G.ModifyChannelInformationBodyContentClassificationLabelId id,
            bool isEnabled)
        {
            this.Id = id;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyChannelInformationBodyContentClassificationLabel" /> class.
        /// </summary>
        public ModifyChannelInformationBodyContentClassificationLabel()
        {
        }
    }
}