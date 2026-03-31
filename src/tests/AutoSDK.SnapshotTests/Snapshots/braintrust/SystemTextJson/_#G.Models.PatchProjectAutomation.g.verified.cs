//HintName: G.Models.PatchProjectAutomation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomation
    {
        /// <summary>
        /// Name of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The configuration for the automation rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.PatchProjectAutomationConfigVariant1, global::G.PatchProjectAutomationConfigVariant2, global::G.PatchProjectAutomationConfigVariant3, global::G.PatchProjectAutomationConfigVariant4, global::G.TopicAutomationConfig, object>))]
        public global::G.AnyOf<global::G.PatchProjectAutomationConfigVariant1, global::G.PatchProjectAutomationConfigVariant2, global::G.PatchProjectAutomationConfigVariant3, global::G.PatchProjectAutomationConfigVariant4, global::G.TopicAutomationConfig, object>? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomation" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the automation rule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectAutomation(
            string? name,
            string? description,
            global::G.AnyOf<global::G.PatchProjectAutomationConfigVariant1, global::G.PatchProjectAutomationConfigVariant2, global::G.PatchProjectAutomationConfigVariant3, global::G.PatchProjectAutomationConfigVariant4, global::G.TopicAutomationConfig, object>? config)
        {
            this.Name = name;
            this.Description = description;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomation" /> class.
        /// </summary>
        public PatchProjectAutomation()
        {
        }
    }
}