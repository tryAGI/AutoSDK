//HintName: G.Models.ProbeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response received after a [probe request](#inspect-media) is submitted. The probe requests returns data from FFprobe formatted as JSON.
    /// </summary>
    public sealed partial class ProbeResponse
    {
        /// <summary>
        /// `true` if media successfully read, else `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// `Created`, `Bad Request` or an error message.<br/>
        /// Example: Created
        /// </summary>
        /// <example>Created</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The response from FFprobe in JSON format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public object Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// `true` if media successfully read, else `false`.<br/>
        /// Example: true
        /// </param>
        /// <param name="message">
        /// `Created`, `Bad Request` or an error message.<br/>
        /// Example: Created
        /// </param>
        /// <param name="response">
        /// The response from FFprobe in JSON format.
        /// </param>
        public ProbeResponse(
            bool success,
            string message,
            object response)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProbeResponse" /> class.
        /// </summary>
        public ProbeResponse()
        {
        }
    }
}