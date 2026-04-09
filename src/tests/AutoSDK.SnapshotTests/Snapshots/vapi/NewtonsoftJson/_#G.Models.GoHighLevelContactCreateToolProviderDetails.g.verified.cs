//HintName: G.Models.GoHighLevelContactCreateToolProviderDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoHighLevelContactCreateToolProviderDetails
    {
        /// <summary>
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("templateUrl")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setupInstructions")]
        public global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? SetupInstructions { get; set; }

        /// <summary>
        /// The type of tool. "gohighlevel.contact.create" for GoHighLevel contact create tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GoHighLevelContactCreateToolProviderDetailsTypeJsonConverter))]
        public global::G.GoHighLevelContactCreateToolProviderDetailsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoHighLevelContactCreateToolProviderDetails" /> class.
        /// </summary>
        /// <param name="templateUrl">
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </param>
        /// <param name="setupInstructions"></param>
        /// <param name="type">
        /// The type of tool. "gohighlevel.contact.create" for GoHighLevel contact create tool.
        /// </param>
        public GoHighLevelContactCreateToolProviderDetails(
            string? templateUrl,
            global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? setupInstructions,
            global::G.GoHighLevelContactCreateToolProviderDetailsType type)
        {
            this.TemplateUrl = templateUrl;
            this.SetupInstructions = setupInstructions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoHighLevelContactCreateToolProviderDetails" /> class.
        /// </summary>
        public GoHighLevelContactCreateToolProviderDetails()
        {
        }
    }
}