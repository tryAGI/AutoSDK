//HintName: G.Models.Error403.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error403
    {
        /// <summary>
        /// Example: forbidden
        /// </summary>
        /// <example>forbidden</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Example: User does not have access to this resource
        /// </summary>
        /// <example>User does not have access to this resource</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: forbidden
        /// </param>
        /// <param name="message">
        /// Example: User does not have access to this resource
        /// </param>
        public Error403(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error403" /> class.
        /// </summary>
        public Error403()
        {
        }
    }
}