//HintName: G.Models.TemplateDataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The template data including the template name and [Edit](#tocs_edit).
    /// </summary>
    public sealed partial class TemplateDataResponse
    {
        /// <summary>
        /// `true` if successfully returned, else `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// `OK`, `Bad Request` or an error message.<br/>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The response data returned with the [TemplateDataResponse](#tocs_templatedataresponse).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateDataResponseData Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDataResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// `true` if successfully returned, else `false`.<br/>
        /// Example: true
        /// </param>
        /// <param name="message">
        /// `OK`, `Bad Request` or an error message.<br/>
        /// Example: OK
        /// </param>
        /// <param name="response">
        /// The response data returned with the [TemplateDataResponse](#tocs_templatedataresponse).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateDataResponse(
            bool success,
            string message,
            global::G.TemplateDataResponseData response)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateDataResponse" /> class.
        /// </summary>
        public TemplateDataResponse()
        {
        }
    }
}