//HintName: G.Models.RetrieveIndexedAssetInformationRequestNotFoundError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetrieveIndexedAssetInformationRequestNotFoundError
    {
        /// <summary>
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

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
        /// Initializes a new instance of the <see cref="RetrieveIndexedAssetInformationRequestNotFoundError" /> class.
        /// </summary>
        /// <param name="code">
        /// Represents the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error.
        /// </param>
        public RetrieveIndexedAssetInformationRequestNotFoundError(
            string? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveIndexedAssetInformationRequestNotFoundError" /> class.
        /// </summary>
        public RetrieveIndexedAssetInformationRequestNotFoundError()
        {
        }
    }
}