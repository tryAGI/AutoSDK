//HintName: G.Models.GetDocumentStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentStatusResponse
    {
        /// <summary>
        /// A unique ID assigned to the uploaded document and the requested translation process. The same ID that was used when requesting the translation status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// A short description of the state the document translation process is currently in. Possible values are:<br/>
        ///  * `queued` - the translation job is waiting in line to be processed<br/>
        ///  * `translating` - the translation is currently ongoing<br/>
        ///  * `done` - the translation is done and the translated document is ready for download<br/>
        ///  * `error` - an irrecoverable error occurred while translating the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetDocumentStatusResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetDocumentStatusResponseStatus Status { get; set; }

        /// <summary>
        /// Estimated number of seconds until the translation is done.<br/>
        /// This parameter is only included while `status` is `"translating"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds_remaining")]
        public int? SecondsRemaining { get; set; }

        /// <summary>
        /// The number of characters billed to your account. The characters will only be billed after a successful download request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_characters")]
        public int? BilledCharacters { get; set; }

        /// <summary>
        /// A short description of the error, if available.<br/>
        /// Note that the content is subject to change.<br/>
        /// This parameter may be included if an error occurred during translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatusResponse" /> class.
        /// </summary>
        /// <param name="documentId">
        /// A unique ID assigned to the uploaded document and the requested translation process. The same ID that was used when requesting the translation status.
        /// </param>
        /// <param name="status">
        /// A short description of the state the document translation process is currently in. Possible values are:<br/>
        ///  * `queued` - the translation job is waiting in line to be processed<br/>
        ///  * `translating` - the translation is currently ongoing<br/>
        ///  * `done` - the translation is done and the translated document is ready for download<br/>
        ///  * `error` - an irrecoverable error occurred while translating the document
        /// </param>
        /// <param name="secondsRemaining">
        /// Estimated number of seconds until the translation is done.<br/>
        /// This parameter is only included while `status` is `"translating"`.
        /// </param>
        /// <param name="billedCharacters">
        /// The number of characters billed to your account. The characters will only be billed after a successful download request.
        /// </param>
        /// <param name="errorMessage">
        /// A short description of the error, if available.<br/>
        /// Note that the content is subject to change.<br/>
        /// This parameter may be included if an error occurred during translation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentStatusResponse(
            string documentId,
            global::G.GetDocumentStatusResponseStatus status,
            int? secondsRemaining,
            int? billedCharacters,
            string? errorMessage)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.Status = status;
            this.SecondsRemaining = secondsRemaining;
            this.BilledCharacters = billedCharacters;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentStatusResponse" /> class.
        /// </summary>
        public GetDocumentStatusResponse()
        {
        }
    }
}