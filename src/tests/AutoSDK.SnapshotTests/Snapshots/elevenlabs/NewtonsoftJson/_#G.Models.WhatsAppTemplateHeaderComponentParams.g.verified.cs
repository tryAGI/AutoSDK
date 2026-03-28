//HintName: G.Models.WhatsAppTemplateHeaderComponentParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WhatsAppTemplateHeaderComponentParams
    {
        /// <summary>
        /// Default Value: header
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ParametersItem> Parameters { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateHeaderComponentParams" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="type">
        /// Default Value: header
        /// </param>
        public WhatsAppTemplateHeaderComponentParams(
            global::System.Collections.Generic.IList<global::G.ParametersItem> parameters,
            string? type)
        {
            this.Type = type;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateHeaderComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateHeaderComponentParams()
        {
        }
    }
}