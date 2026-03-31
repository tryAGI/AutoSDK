//HintName: G.Models.PatchProjectAutomationConfigVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchProjectAutomationConfigVariant3
    {
        /// <summary>
        /// The type of automation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter))]
        public global::G.PatchProjectAutomationConfigVariant3EventType EventType { get; set; }

        /// <summary>
        /// The object type that the retention policy applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetentionObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RetentionObjectType ObjectType { get; set; }

        /// <summary>
        /// The number of days to retain the object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant3" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectAutomationConfigVariant3(
            global::G.RetentionObjectType objectType,
            double retentionDays,
            global::G.PatchProjectAutomationConfigVariant3EventType eventType)
        {
            this.EventType = eventType;
            this.ObjectType = objectType;
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectAutomationConfigVariant3" /> class.
        /// </summary>
        public PatchProjectAutomationConfigVariant3()
        {
        }
    }
}