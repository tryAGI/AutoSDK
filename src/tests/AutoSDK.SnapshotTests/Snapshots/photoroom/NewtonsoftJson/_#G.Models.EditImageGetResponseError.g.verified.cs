//HintName: G.Models.EditImageGetResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetResponseError
    {
        /// <summary>
        /// The message describing the error<br/>
        /// Example: imageUrl: must be provided
        /// </summary>
        /// <example>imageUrl: must be provided</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error<br/>
        /// Example: imageUrl: must be provided
        /// </param>
        public EditImageGetResponseError(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetResponseError" /> class.
        /// </summary>
        public EditImageGetResponseError()
        {
        }
    }
}