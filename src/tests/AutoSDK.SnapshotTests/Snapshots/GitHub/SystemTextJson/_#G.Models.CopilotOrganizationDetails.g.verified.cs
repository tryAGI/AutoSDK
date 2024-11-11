//HintName: G.Models.CopilotOrganizationDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the seat breakdown and policies set for an organization with a Copilot Business or Copilot Enterprise subscription.
    /// </summary>
    public sealed partial class CopilotOrganizationDetails
    {
        /// <summary>
        /// The breakdown of Copilot Business seats for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CopilotSeatBreakdown SeatBreakdown { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_code_suggestions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsPublicCodeSuggestionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CopilotOrganizationDetailsPublicCodeSuggestions PublicCodeSuggestions { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ide_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsIdeChatJsonConverter))]
        public global::G.CopilotOrganizationDetailsIdeChat? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_chat")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsPlatformChatJsonConverter))]
        public global::G.CopilotOrganizationDetailsPlatformChat? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cli")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsCliJsonConverter))]
        public global::G.CopilotOrganizationDetailsCli? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_management_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsSeatManagementSettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CopilotOrganizationDetailsSeatManagementSetting SeatManagementSetting { get; set; }

        /// <summary>
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CopilotOrganizationDetailsPlanTypeJsonConverter))]
        public global::G.CopilotOrganizationDetailsPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotOrganizationDetails" /> class.
        /// </summary>
        /// <param name="seatBreakdown">
        /// The breakdown of Copilot Business seats for the organization.
        /// </param>
        /// <param name="publicCodeSuggestions">
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </param>
        /// <param name="ideChat">
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </param>
        /// <param name="platformChat">
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </param>
        /// <param name="cli">
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </param>
        /// <param name="seatManagementSetting">
        /// The mode of assigning new seats.
        /// </param>
        /// <param name="planType">
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotOrganizationDetails(
            global::G.CopilotSeatBreakdown seatBreakdown,
            global::G.CopilotOrganizationDetailsPublicCodeSuggestions publicCodeSuggestions,
            global::G.CopilotOrganizationDetailsSeatManagementSetting seatManagementSetting,
            global::G.CopilotOrganizationDetailsIdeChat? ideChat,
            global::G.CopilotOrganizationDetailsPlatformChat? platformChat,
            global::G.CopilotOrganizationDetailsCli? cli,
            global::G.CopilotOrganizationDetailsPlanType? planType)
        {
            this.SeatBreakdown = seatBreakdown ?? throw new global::System.ArgumentNullException(nameof(seatBreakdown));
            this.PublicCodeSuggestions = publicCodeSuggestions;
            this.SeatManagementSetting = seatManagementSetting;
            this.IdeChat = ideChat;
            this.PlatformChat = platformChat;
            this.Cli = cli;
            this.PlanType = planType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotOrganizationDetails" /> class.
        /// </summary>
        public CopilotOrganizationDetails()
        {
        }
    }
}