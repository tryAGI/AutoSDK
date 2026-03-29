//HintName: G.Models.RenderResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response received after a [render status request](#get-render-status) is submitted. The response includes  details about status of a render and the output URL.
    /// </summary>
    public sealed partial class RenderResponse
    {
        /// <summary>
        /// `true` if status available, else `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// `OK` or an error message.<br/>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The response data returned with the [RenderResponse](#tocs_renderresponse) including status and URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RenderResponseData Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// `true` if status available, else `false`.<br/>
        /// Example: true
        /// </param>
        /// <param name="message">
        /// `OK` or an error message.<br/>
        /// Example: OK
        /// </param>
        /// <param name="response">
        /// The response data returned with the [RenderResponse](#tocs_renderresponse) including status and URL.
        /// </param>
        public RenderResponse(
            bool success,
            string message,
            global::G.RenderResponseData response)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenderResponse" /> class.
        /// </summary>
        public RenderResponse()
        {
        }
    }
}