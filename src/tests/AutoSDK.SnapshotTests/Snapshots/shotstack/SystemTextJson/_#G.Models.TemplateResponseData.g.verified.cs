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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The unique id of the template in UUID format.<br/>
        /// Example: f5493c17-d01f-445c-bb49-535fae65f219
        /// </summary>
        /// <example>f5493c17-d01f-445c-bb49-535fae65f219</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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