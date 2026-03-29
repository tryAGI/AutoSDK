//HintName: G.Models.TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        public TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2" /> class.
        /// </summary>
        public TemplatesUpdateCurrentTemplateFromAgentFileNoProjectResponse2()
        {
        }
    }
}