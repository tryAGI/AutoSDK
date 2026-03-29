//HintName: G.Models.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomationConfigVariant2ExportDefinitionVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type Type { get; set; }

        /// <summary>
        /// The BTQL query to export
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btql_query", Required = global::Newtonsoft.Json.Required.Always)]
        public string BtqlQuery { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant2ExportDefinitionVariant3" /> class.
        /// </summary>
        /// <param name="btqlQuery">
        /// The BTQL query to export
        /// </param>
        /// <param name="type"></param>
        public PatchProjectAutomationConfigVariant2ExportDefinitionVariant3(
            string btqlQuery,
            global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type type)
        {
            this.Type = type;
            this.BtqlQuery = btqlQuery ?? throw new global::System.ArgumentNullException(nameof(btqlQuery));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant2ExportDefinitionVariant3" /> class.
        /// </summary>
        public PatchProjectAutomationConfigVariant2ExportDefinitionVariant3()
        {
        }
    }
}