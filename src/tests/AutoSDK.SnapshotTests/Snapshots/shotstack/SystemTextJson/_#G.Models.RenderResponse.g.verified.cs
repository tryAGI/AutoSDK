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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// `OK` or an error message.<br/>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The response data returned with the [RenderResponse](#tocs_renderresponse) including status and URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RenderResponseData Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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