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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter))]
        public global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3Type Type { get; set; }

        /// <summary>
        /// The BTQL query to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BtqlQuery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant2ExportDefinitionVariant3" /> class.
        /// </summary>
        /// <param name="btqlQuery">
        /// The BTQL query to export
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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