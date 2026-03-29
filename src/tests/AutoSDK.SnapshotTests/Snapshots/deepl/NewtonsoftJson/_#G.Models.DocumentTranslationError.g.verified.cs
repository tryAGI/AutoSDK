//HintName: G.Models.DocumentTranslationError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentTranslationError
    {
        /// <summary>
        /// detailed error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTranslationError" /> class.
        /// </summary>
        /// <param name="message">
        /// detailed error message
        /// </param>
        public DocumentTranslationError(
            string? message)
        {
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTranslationError" /> class.
        /// </summary>
        public DocumentTranslationError()
        {
        }
    }
}