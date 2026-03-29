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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the dubbed video.<br/>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter))]
        public global::G.GetDubbingProjectVideosResponseErrorStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PublicApiImportedAndDubbedVideosErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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