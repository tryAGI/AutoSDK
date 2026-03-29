//HintName: G.Models.DubbedAssetInProgress.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbed asset in progress - minimal data.
    /// </summary>
    public sealed partial class DubbedAssetInProgress
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbingOutputLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DubbingOutputLanguage Language { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DubbedAssetInProgressStatusJsonConverter))]
        public global::G.DubbedAssetInProgressStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetInProgress" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbedAssetInProgress(
            global::System.Guid id,
            global::G.DubbingOutputLanguage language,
            global::G.DubbedAssetInProgressStatus? status)
        {
            this.Id = id;
            this.Language = language;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetInProgress" /> class.
        /// </summary>
        public DubbedAssetInProgress()
        {
        }
    }
}