//HintName: G.Models.GoHighLevelCalendarAvailabilityToolProviderDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoHighLevelCalendarAvailabilityToolProviderDetails
    {
        /// <summary>
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateUrl")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setupInstructions")]
        public global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? SetupInstructions { get; set; }

        /// <summary>
        /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar availability check tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GoHighLevelCalendarAvailabilityToolProviderDetailsTypeJsonConverter))]
        public global::G.GoHighLevelCalendarAvailabilityToolProviderDetailsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoHighLevelCalendarAvailabilityToolProviderDetails" /> class.
        /// </summary>
        /// <param name="templateUrl">
        /// This is the Template URL or the Snapshot URL corresponding to the Template.
        /// </param>
        /// <param name="setupInstructions"></param>
        /// <param name="type">
        /// The type of tool. "gohighlevel.calendar.availability.check" for GoHighLevel Calendar availability check tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoHighLevelCalendarAvailabilityToolProviderDetails(
            string? templateUrl,
            global::System.Collections.Generic.IList<global::G.ToolTemplateSetup>? setupInstructions,
            global::G.GoHighLevelCalendarAvailabilityToolProviderDetailsType type)
        {
            this.TemplateUrl = templateUrl;
            this.SetupInstructions = setupInstructions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoHighLevelCalendarAvailabilityToolProviderDetails" /> class.
        /// </summary>
        public GoHighLevelCalendarAvailabilityToolProviderDetails()
        {
        }
    }
}