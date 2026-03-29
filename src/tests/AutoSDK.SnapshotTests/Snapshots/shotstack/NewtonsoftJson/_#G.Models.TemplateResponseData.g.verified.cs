//HintName: G.Models.TemplateResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response data returned with the [TemplateResponse](#tocs_templateresponse).
    /// </summary>
    public sealed partial class TemplateResponseData
    {
        /// <summary>
        /// Success response message or error details.<br/>
        /// Example: Template Successfully Created
        /// </summary>
        /// <example>Template Successfully Created</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseData" /> class.
        /// </summary>
        /// <param name="message">
        /// Success response message or error details.<br/>
        /// Example: Template Successfully Created
        /// </param>
        /// <param name="id">
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </param>
        public TemplateResponseData(
            string message,
            string id)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseData" /> class.
        /// </summary>
        public TemplateResponseData()
        {
        }
    }
}