//HintName: G.Models.AnyToVideoRetrieveSpecificPageRequestBadRequestError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnyToVideoRetrieveSpecificPageRequestBadRequestError
    {
        /// <summary>
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// A human-readable string describing the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnyToVideoRetrieveSpecificPageRequestBadRequestError" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error.
        /// </param>
        public AnyToVideoRetrieveSpecificPageRequestBadRequestError(
            int? errorCode,
            string? message)
        {
            this.ErrorCode = errorCode;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnyToVideoRetrieveSpecificPageRequestBadRequestError" /> class.
        /// </summary>
        public AnyToVideoRetrieveSpecificPageRequestBadRequestError()
        {
        }
    }
}