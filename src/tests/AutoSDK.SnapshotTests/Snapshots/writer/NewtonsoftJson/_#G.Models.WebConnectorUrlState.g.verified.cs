//HintName: G.Models.WebConnectorUrlState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of a web connector URL processing.
    /// </summary>
    public sealed partial class WebConnectorUrlState
    {
        /// <summary>
        /// The status of web connector URL processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlStatusJsonConverter))]
        public global::G.WebConnectorUrlStatus Status { get; set; } = default!;

        /// <summary>
        /// The type of error that can occur during web connector URL processing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlErrorTypeJsonConverter))]
        public global::G.WebConnectorUrlErrorType? ErrorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebConnectorUrlState" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of web connector URL processing.
        /// </param>
        /// <param name="errorType">
        /// The type of error that can occur during web connector URL processing.
        /// </param>
        public WebConnectorUrlState(
            global::G.WebConnectorUrlStatus status,
            global::G.WebConnectorUrlErrorType? errorType)
        {
            this.Status = status;
            this.ErrorType = errorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebConnectorUrlState" /> class.
        /// </summary>
        public WebConnectorUrlState()
        {
        }
    }
}