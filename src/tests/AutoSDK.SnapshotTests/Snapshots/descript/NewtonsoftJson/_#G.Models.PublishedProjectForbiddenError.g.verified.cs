//HintName: G.Models.PublishedProjectForbiddenError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response when the user does not have access to the published project
    /// </summary>
    public sealed partial class PublishedProjectForbiddenError
    {
        /// <summary>
        /// Error type identifier<br/>
        /// Example: forbidden
        /// </summary>
        /// <example>forbidden</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::G.PublishedProjectForbiddenErrorError? Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: User id 00000000-0000-0000-0000-000000000000 does not have access to this project
        /// </summary>
        /// <example>User id 00000000-0000-0000-0000-000000000000 does not have access to this project</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectForbiddenError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error type identifier<br/>
        /// Example: forbidden
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: User id 00000000-0000-0000-0000-000000000000 does not have access to this project
        /// </param>
        public PublishedProjectForbiddenError(
            global::G.PublishedProjectForbiddenErrorError? error,
            string? message)
        {
            this.Error = error;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishedProjectForbiddenError" /> class.
        /// </summary>
        public PublishedProjectForbiddenError()
        {
        }
    }
}