//HintName: G.Models.WhatsAppTemplateButtonComponentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateButtonComponentParams
    {
        /// <summary>
        /// Default Value: button
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WhatsAppTemplateTextParam> Parameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string SubType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateButtonComponentParams" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: button
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="index"></param>
        /// <param name="subType"></param>
        public WhatsAppTemplateButtonComponentParams(
            global::System.Collections.Generic.IList<global::G.WhatsAppTemplateTextParam> parameters,
            int index,
            string subType,
            string? type)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Index = index;
            this.SubType = subType ?? throw new global::System.ArgumentNullException(nameof(subType));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateButtonComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateButtonComponentParams()
        {
        }
    }
}