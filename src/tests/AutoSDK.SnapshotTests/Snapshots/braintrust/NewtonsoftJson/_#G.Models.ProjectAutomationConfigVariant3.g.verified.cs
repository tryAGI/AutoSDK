//HintName: G.Models.ProjectAutomationConfigVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant3
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter))]
        public global::G.ProjectAutomationConfigVariant3EventType EventType { get; set; }

        /// <summary>
        /// The object type that the retention policy applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RetentionObjectTypeJsonConverter))]
        public global::G.RetentionObjectType ObjectType { get; set; } = default!;

        /// <summary>
        /// The number of days to retain the object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retention_days", Required = global::Newtonsoft.Json.Required.Always)]
        public double RetentionDays { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant3" /> class.
        /// </summary>
        /// <param name="objectType">
        /// The object type that the retention policy applies to
        /// </param>
        /// <param name="retentionDays">
        /// The number of days to retain the object
        /// </param>
        /// <param name="eventType">
        /// The type of automation.
        /// </param>
        public ProjectAutomationConfigVariant3(
            global::G.RetentionObjectType objectType,
            double retentionDays,
            global::G.ProjectAutomationConfigVariant3EventType eventType)
        {
            this.EventType = eventType;
            this.ObjectType = objectType;
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant3" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant3()
        {
        }
    }
}