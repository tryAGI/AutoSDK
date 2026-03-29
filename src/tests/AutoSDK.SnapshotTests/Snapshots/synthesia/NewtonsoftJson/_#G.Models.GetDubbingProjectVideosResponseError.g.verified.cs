//HintName: G.Models.GetDubbingProjectVideosResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response when dubbing project encountered an error.
    /// </summary>
    public sealed partial class GetDubbingProjectVideosResponseError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.GetDubbingProjectVideosResponseErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PublicApiImportedAndDubbedVideosErrorCode ErrorCode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseError" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="errorCode"></param>
        /// <param name="status">
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </param>
        public GetDubbingProjectVideosResponseError(
            global::System.Guid id,
            global::G.PublicApiImportedAndDubbedVideosErrorCode errorCode,
            global::G.GetDubbingProjectVideosResponseErrorStatus? status)
        {
            this.Id = id;
            this.Status = status;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDubbingProjectVideosResponseError" /> class.
        /// </summary>
        public GetDubbingProjectVideosResponseError()
        {
        }
    }
}