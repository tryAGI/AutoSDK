//HintName: G.Models.BetaErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaErrorResponse
    {
        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>global::G.BetaErrorResponseType.Error</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaErrorResponseType Type { get; set; } = global::G.BetaErrorResponseType.Error;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Error Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
        public BetaErrorResponse(
            global::G.Error error,
            global::G.BetaErrorResponseType type = global::G.BetaErrorResponseType.Error)
        {
            this.Error = error;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErrorResponse" /> class.
        /// </summary>
        public BetaErrorResponse()
        {
        }
    }
}