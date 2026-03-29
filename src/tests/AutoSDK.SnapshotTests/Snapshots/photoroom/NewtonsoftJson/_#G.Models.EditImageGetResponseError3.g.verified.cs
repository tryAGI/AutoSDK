//HintName: G.Models.EditImageGetResponseError3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImageGetResponseError3
    {
        /// <summary>
        /// The message describing the error<br/>
        /// Example: An unexpected error occurred. Please try again later or contact support.
        /// </summary>
        /// <example>An unexpected error occurred. Please try again later or contact support.</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetResponseError3" /> class.
        /// </summary>
        /// <param name="message">
        /// The message describing the error<br/>
        /// Example: An unexpected error occurred. Please try again later or contact support.
        /// </param>
        public EditImageGetResponseError3(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImageGetResponseError3" /> class.
        /// </summary>
        public EditImageGetResponseError3()
        {
        }
    }
}