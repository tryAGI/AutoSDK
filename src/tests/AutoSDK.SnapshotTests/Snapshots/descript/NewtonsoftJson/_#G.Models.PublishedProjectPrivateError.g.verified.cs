//HintName: G.Models.PublishedProjectPrivateError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response when published project is private to drive and user is unauthenticated
    /// </summary>
    public sealed partial class PublishedProjectPrivateError
    {
        /// <summary>
        /// Error type identifier<br/>
        /// Example: unauthorized
        /// </summary>
        /// <example>unauthorized</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.PublishedProjectPrivateErrorError? Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Private to drive, user must log in to account with access.
        /// </summary>
        /// <example>Private to drive, user must log in to account with access.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectPrivateError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error type identifier<br/>
        /// Example: unauthorized
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Private to drive, user must log in to account with access.
        /// </param>
        public PublishedProjectPrivateError(
            global::G.PublishedProjectPrivateErrorError? error,
            string? message)
        {
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectPrivateError" /> class.
        /// </summary>
        public PublishedProjectPrivateError()
        {
        }
    }
}