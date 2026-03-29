//HintName: G.Models.HttpError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpError
    {
        /// <summary>
        /// A valid http status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        /// A message explaining the status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Used to describe the origin of an error if that original error has meaning to the client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public string? Cause { get; set; }

        /// <summary>
        /// Used to identify specific fields in a JSON body that caused the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Fields { get; set; }

        /// <summary>
        /// Used to identify what part of the request caused the error for non-JSON payloads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpError" /> class.
        /// </summary>
        /// <param name="status">
        /// A valid http status code
        /// </param>
        /// <param name="message">
        /// A message explaining the status
        /// </param>
        /// <param name="cause">
        /// Used to describe the origin of an error if that original error has meaning to the client.
        /// </param>
        /// <param name="fields">
        /// Used to identify specific fields in a JSON body that caused the error.
        /// </param>
        /// <param name="context">
        /// Used to identify what part of the request caused the error for non-JSON payloads.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpError(
            int status,
            string message,
            string? cause,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? fields,
            string? context)
        {
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Cause = cause;
            this.Fields = fields;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpError" /> class.
        /// </summary>
        public HttpError()
        {
        }
    }
}