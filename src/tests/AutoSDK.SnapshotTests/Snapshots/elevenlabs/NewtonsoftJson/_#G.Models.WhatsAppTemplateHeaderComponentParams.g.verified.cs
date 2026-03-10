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
        /// <param name="type">
        /// Default Value: header
        /// </param>
        /// <param name="parameters"></param>
        public WhatsAppTemplateHeaderComponentParams(
            global::System.Collections.Generic.IList<global::G.ParametersItem> parameters,
            string? type)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateHeaderComponentParams" /> class.
        /// </summary>
        public WhatsAppTemplateHeaderComponentParams()
        {
        }
    }
}