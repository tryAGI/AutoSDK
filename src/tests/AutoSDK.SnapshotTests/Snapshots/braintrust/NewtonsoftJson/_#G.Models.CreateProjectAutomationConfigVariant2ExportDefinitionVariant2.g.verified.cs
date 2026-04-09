//HintName: G.Models.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant2ExportDefinitionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter))]
        public global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant2ExportDefinitionVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        public CreateProjectAutomationConfigVariant2ExportDefinitionVariant2(
            global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant2ExportDefinitionVariant2" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant2ExportDefinitionVariant2()
        {
        }
    }
}