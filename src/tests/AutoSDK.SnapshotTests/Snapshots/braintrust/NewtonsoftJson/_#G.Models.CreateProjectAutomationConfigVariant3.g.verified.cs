//HintName: G.Models.CreateProjectAutomationConfigVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant3
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type")]
        public global::G.CreateProjectAutomationConfigVariant3EventType EventType { get; set; }

        /// <summary>
        /// The object type that the retention policy applies to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
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
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant3" /> class.
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
        public CreateProjectAutomationConfigVariant3(
            global::G.RetentionObjectType objectType,
            double retentionDays,
            global::G.CreateProjectAutomationConfigVariant3EventType eventType)
        {
            this.EventType = eventType;
            this.ObjectType = objectType;
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant3" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant3()
        {
        }
    }
}