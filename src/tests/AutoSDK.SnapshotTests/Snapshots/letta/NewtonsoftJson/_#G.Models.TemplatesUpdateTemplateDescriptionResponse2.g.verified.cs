//HintName: G.Models.TemplatesUpdateTemplateDescriptionResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesUpdateTemplateDescriptionResponse2
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
        /// Initializes a new instance of the <see cref="TemplatesUpdateTemplateDescriptionResponse2" /> class.
        /// </summary>
        /// <param name="message"></param>
        public TemplatesUpdateTemplateDescriptionResponse2(
            string message)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesUpdateTemplateDescriptionResponse2" /> class.
        /// </summary>
        public TemplatesUpdateTemplateDescriptionResponse2()
        {
        }
    }
}