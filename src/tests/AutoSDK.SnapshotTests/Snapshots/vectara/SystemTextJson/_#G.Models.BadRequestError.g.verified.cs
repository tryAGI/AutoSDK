//HintName: G.Models.BadRequestError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BadRequestError
    {
        /// <summary>
        /// The errors that relate to specific fields in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_errors")]
        public global::System.Collections.Generic.Dictionary<string, string>? FieldErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestError" /> class.
        /// </summary>
        /// <param name="fieldErrors">
        /// The errors that relate to specific fields in the request.
        /// </param>
        /// <param name="messages"></param>
        /// <param name="requestId">
        /// The ID of the request that can be used to help Vectara support debug what went wrong.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BadRequestError(
            global::System.Collections.Generic.Dictionary<string, string>? fieldErrors,
            global::System.Collections.Generic.IList<string>? messages,
            string? requestId)
        {
            this.FieldErrors = fieldErrors;
            this.Messages = messages;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestError" /> class.
        /// </summary>
        public BadRequestError()
        {
        }
    }
}