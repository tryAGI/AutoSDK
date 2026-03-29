//HintName: G.Models.Error401.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error401
    {
        /// <summary>
        /// Example: unauthorized
        /// </summary>
        /// <example>unauthorized</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Example: Missing or invalid authentication token
        /// </summary>
        /// <example>Missing or invalid authentication token</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error401" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: unauthorized
        /// </param>
        /// <param name="message">
        /// Example: Missing or invalid authentication token
        /// </param>
        public Error401(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error401" /> class.
        /// </summary>
        public Error401()
        {
        }
    }
}