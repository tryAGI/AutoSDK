//HintName: G.Models.WhatsAppTemplateImageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateImageParam
    {
        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WhatsAppTemplateImageParamDetails Image { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateImageParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: image
        /// </param>
        /// <param name="image"></param>
        public WhatsAppTemplateImageParam(
            global::G.WhatsAppTemplateImageParamDetails image,
            string? type)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateImageParam" /> class.
        /// </summary>
        public WhatsAppTemplateImageParam()
        {
        }
    }
}