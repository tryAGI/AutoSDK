//HintName: G.Models.ProjectAutomationConfigVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant4
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter))]
        public global::G.ProjectAutomationConfigVariant4EventType EventType { get; set; }

        /// <summary>
        /// Optional list of environment slugs to filter by
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_filter")]
        public global::System.Collections.Generic.IList<string>? EnvironmentFilter { get; set; }

        /// <summary>
        /// The action to take when the automation rule is triggered
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.ProjectAutomationConfigVariant4ActionVariant1, global::G.ProjectAutomationConfigVariant4ActionVariant2> Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant4" /> class.
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
        public ProjectAutomationConfigVariant4(
            global::G.OneOf<global::G.ProjectAutomationConfigVariant4ActionVariant1, global::G.ProjectAutomationConfigVariant4ActionVariant2> action,
            global::G.ProjectAutomationConfigVariant4EventType eventType,
            global::System.Collections.Generic.IList<string>? environmentFilter)
        {
            this.EventType = eventType;
            this.EnvironmentFilter = environmentFilter;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant4" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant4()
        {
        }
    }
}