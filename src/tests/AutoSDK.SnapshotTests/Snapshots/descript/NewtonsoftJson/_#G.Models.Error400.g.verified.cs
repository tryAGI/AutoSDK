//HintName: G.Models.Error400.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error400
    {
        /// <summary>
        /// Example: invalid_input
        /// </summary>
        /// <example>invalid_input</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Example: Invalid request body
        /// </summary>
        /// <example>Invalid request body</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error400" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: invalid_input
        /// </param>
        /// <param name="message">
        /// Example: Invalid request body
        /// </param>
        public Error400(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error400" /> class.
        /// </summary>
        public Error400()
        {
        }
    }
}