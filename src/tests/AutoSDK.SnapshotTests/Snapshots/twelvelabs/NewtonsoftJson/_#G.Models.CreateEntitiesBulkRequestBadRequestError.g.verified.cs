//HintName: G.Models.CreateEntitiesBulkRequestBadRequestError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEntitiesBulkRequestBadRequestError
    {
        /// <summary>
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The URL of the relevant documentation page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("docs_url")]
        public string? DocsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntitiesBulkRequestBadRequestError" /> class.
        /// </summary>
        /// <param name="code">
        /// A string representing the code associated with the error. See the [Error codes](/v1.3/api-reference/error-codes) page for details.
        /// </param>
        /// <param name="message">
        /// A human-readable string describing the error, intended to be suitable for display in a user interface.
        /// </param>
        /// <param name="docsUrl">
        /// The URL of the relevant documentation page.
        /// </param>
        public CreateEntitiesBulkRequestBadRequestError(
            string? code,
            string? message,
            string? docsUrl)
        {
            this.Code = code;
            this.Message = message;
            this.DocsUrl = docsUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntitiesBulkRequestBadRequestError" /> class.
        /// </summary>
        public CreateEntitiesBulkRequestBadRequestError()
        {
        }
    }
}