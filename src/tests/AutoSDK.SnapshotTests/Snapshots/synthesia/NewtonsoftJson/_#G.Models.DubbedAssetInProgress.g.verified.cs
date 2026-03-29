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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DubbingOutputLanguage Language { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: in_progress
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.DubbedAssetInProgressStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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