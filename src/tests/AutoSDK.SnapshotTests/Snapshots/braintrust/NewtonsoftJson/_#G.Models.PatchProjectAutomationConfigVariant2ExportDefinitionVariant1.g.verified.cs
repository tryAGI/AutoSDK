//HintName: G.Models.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomationConfigVariant2ExportDefinitionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant2ExportDefinitionVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        public PatchProjectAutomationConfigVariant2ExportDefinitionVariant1(
            global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant2ExportDefinitionVariant1" /> class.
        /// </summary>
        public PatchProjectAutomationConfigVariant2ExportDefinitionVariant1()
        {
        }
    }
}