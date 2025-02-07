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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaErrorResponseTypeJsonConverter))]
        public global::G.BetaErrorResponseType Type { get; set; } = global::G.BetaErrorResponseType.Error;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Error Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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