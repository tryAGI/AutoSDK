//HintName: G.Models.TemplateListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of previously saved templates.
    /// </summary>
    public sealed partial class TemplateListResponse
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
        /// The response data returned with the [TemplateListResponse](#tocs_templatelistresponse).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TemplateListResponseData Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
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
        /// The response data returned with the [TemplateListResponse](#tocs_templatelistresponse).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateListResponse(
            bool success,
            string message,
            global::G.TemplateListResponseData response)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateListResponse" /> class.
        /// </summary>
        public TemplateListResponse()
        {
        }
    }
}