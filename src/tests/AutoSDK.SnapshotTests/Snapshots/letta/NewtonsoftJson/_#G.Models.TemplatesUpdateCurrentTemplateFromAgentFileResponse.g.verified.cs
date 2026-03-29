//HintName: G.Models.TemplatesUpdateCurrentTemplateFromAgentFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesUpdateCurrentTemplateFromAgentFileResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public TemplatesUpdateCurrentTemplateFromAgentFileResponse(
            bool success,
            string? message)
        {
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileResponse" /> class.
        /// </summary>
        public TemplatesUpdateCurrentTemplateFromAgentFileResponse()
        {
        }
    }
}