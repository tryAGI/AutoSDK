//HintName: G.Models.PatchProjectAutomationConfigVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomationConfigVariant4
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter))]
        public global::G.PatchProjectAutomationConfigVariant4EventType EventType { get; set; }

        /// <summary>
        /// Optional list of environment slugs to filter by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_filter")]
        public global::System.Collections.Generic.IList<string>? EnvironmentFilter { get; set; }

        /// <summary>
        /// The action to take when the automation rule is triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PatchProjectAutomationConfigVariant4ActionVariant1, global::G.PatchProjectAutomationConfigVariant4ActionVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PatchProjectAutomationConfigVariant4ActionVariant1, global::G.PatchProjectAutomationConfigVariant4ActionVariant2> Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant4" /> class.
        /// </summary>
        /// <param name="action">
        /// The action to take when the automation rule is triggered
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        /// <param name="environmentFilter">
        /// Optional list of environment slugs to filter by
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectAutomationConfigVariant4(
            global::G.OneOf<global::G.PatchProjectAutomationConfigVariant4ActionVariant1, global::G.PatchProjectAutomationConfigVariant4ActionVariant2> action,
            global::G.PatchProjectAutomationConfigVariant4EventType eventType,
            global::System.Collections.Generic.IList<string>? environmentFilter)
        {
            this.EventType = eventType;
            this.EnvironmentFilter = environmentFilter;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant4" /> class.
        /// </summary>
        public PatchProjectAutomationConfigVariant4()
        {
        }
    }
}