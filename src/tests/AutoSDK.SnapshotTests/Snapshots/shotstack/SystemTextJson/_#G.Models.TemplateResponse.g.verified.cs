//HintName: G.Models.TemplateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response received after a [template](#create-template) is submitted. The template is saved and a unique template id is returned.
    /// </summary>
    public sealed partial class TemplateResponse
    {
        /// <summary>
        /// `true` if successfully created, else `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// `Created`, `Bad Request` or an error message.<br/>
        /// Example: Created
        /// </summary>
        /// <example>Created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The response data returned with the [TemplateResponse](#tocs_templateresponse).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateResponseData Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// `true` if successfully created, else `false`.<br/>
        /// Example: true
        /// </param>
        /// <param name="message">
        /// `Created`, `Bad Request` or an error message.<br/>
        /// Example: Created
        /// </param>
        /// <param name="response">
        /// The response data returned with the [TemplateResponse](#tocs_templateresponse).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateResponse(
            bool success,
            string message,
            global::G.TemplateResponseData response)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponse" /> class.
        /// </summary>
        public TemplateResponse()
        {
        }
    }
}