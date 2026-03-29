//HintName: G.Models.Error404.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error404
    {
        /// <summary>
        /// Example: not_found
        /// </summary>
        /// <example>not_found</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Example: Resource not found
        /// </summary>
        /// <example>Resource not found</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error404" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: not_found
        /// </param>
        /// <param name="message">
        /// Example: Resource not found
        /// </param>
        public Error404(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error404" /> class.
        /// </summary>
        public Error404()
        {
        }
    }
}