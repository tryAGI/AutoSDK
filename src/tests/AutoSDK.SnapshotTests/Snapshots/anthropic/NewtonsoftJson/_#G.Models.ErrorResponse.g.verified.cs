//HintName: G.Models.ErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Default Value: error
        /// </summary>
        /// <default>global::G.ErrorResponseType.Error</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ErrorResponseType Type { get; set; } = global::G.ErrorResponseType.Error;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Error2 Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
        public ErrorResponse(
            global::G.Error2 error,
            global::G.ErrorResponseType type = global::G.ErrorResponseType.Error)
        {
            this.Error = error;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}