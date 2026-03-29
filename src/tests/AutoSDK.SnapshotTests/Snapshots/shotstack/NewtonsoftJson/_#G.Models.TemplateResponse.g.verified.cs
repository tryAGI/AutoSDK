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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// `Created`, `Bad Request` or an error message.<br/>
        /// Example: Created
        /// </summary>
        /// <example>Created</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The response data returned with the [TemplateResponse](#tocs_templateresponse).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TemplateResponseData Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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