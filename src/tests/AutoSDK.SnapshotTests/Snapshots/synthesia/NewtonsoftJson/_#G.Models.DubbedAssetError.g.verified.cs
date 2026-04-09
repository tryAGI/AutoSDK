//HintName: G.Models.DubbedAssetError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dubbed asset error - minimal data + error code.
    /// </summary>
    public sealed partial class DubbedAssetError
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DubbingOutputLanguageJsonConverter))]
        public global::G.DubbingOutputLanguage Language { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DubbedAssetErrorStatusJsonConverter))]
        public global::G.DubbedAssetErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter))]
        public global::G.PublicApiImportedAndDubbedVideosErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetError" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="errorCode"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </param>
        public DubbedAssetError(
            global::System.Guid id,
            global::G.DubbingOutputLanguage language,
            global::G.PublicApiImportedAndDubbedVideosErrorCode errorCode,
            global::G.DubbedAssetErrorStatus? status)
        {
            this.Id = id;
            this.Language = language;
            this.Status = status;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbedAssetError" /> class.
        /// </summary>
        public DubbedAssetError()
        {
        }
    }
}