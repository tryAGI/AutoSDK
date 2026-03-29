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
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// `OK`, `Bad Request` or an error message.<br/>
        /// Example: OK
        /// </summary>
        /// <example>OK</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The response data returned with the [TemplateListResponse](#tocs_templatelistresponse).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TemplateListResponseData Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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