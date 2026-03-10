//HintName: G.Models.WhatsAppTemplateLocationParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateLocationParam
    {
        /// <summary>
        /// Default Value: location
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WhatsAppTemplateLocationParamDetails Location { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: location
        /// </param>
        /// <param name="location"></param>
        public WhatsAppTemplateLocationParam(
            global::G.WhatsAppTemplateLocationParamDetails location,
            string? type)
        {
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateLocationParam" /> class.
        /// </summary>
        public WhatsAppTemplateLocationParam()
        {
        }
    }
}