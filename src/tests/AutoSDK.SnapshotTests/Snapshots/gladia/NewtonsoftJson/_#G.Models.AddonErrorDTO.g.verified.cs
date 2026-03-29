//HintName: G.Models.AddonErrorDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddonErrorDTO
    {
        /// <summary>
        /// Status code of the addon error<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Reason of the addon error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exception", Required = global::Newtonsoft.Json.Required.Always)]
        public string Exception { get; set; } = default!;

        /// <summary>
        /// Detailed message of the addon error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonErrorDTO" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// Status code of the addon error<br/>
        /// Example: 500
        /// </param>
        /// <param name="exception">
        /// Reason of the addon error
        /// </param>
        /// <param name="message">
        /// Detailed message of the addon error
        /// </param>
        public AddonErrorDTO(
            int statusCode,
            string exception,
            string message)
        {
            this.StatusCode = statusCode;
            this.Exception = exception ?? throw new global::System.ArgumentNullException(nameof(exception));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddonErrorDTO" /> class.
        /// </summary>
        public AddonErrorDTO()
        {
        }
    }
}