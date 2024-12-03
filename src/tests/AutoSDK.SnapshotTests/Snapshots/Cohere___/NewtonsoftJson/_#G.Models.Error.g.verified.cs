//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error is the response for any unsuccessful event.
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// A developer-facing error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="message">
        /// A developer-facing error message.
        /// </param>
        public Error(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}