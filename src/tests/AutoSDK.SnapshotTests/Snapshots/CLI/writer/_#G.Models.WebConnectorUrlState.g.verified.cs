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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebConnectorUrlStatus Status { get; set; }

        /// <summary>
        /// The type of error that can occur during web connector URL processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebConnectorUrlErrorTypeJsonConverter))]
        public global::G.WebConnectorUrlErrorType? ErrorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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