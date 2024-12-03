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
        [global::Newtonsoft.Json.JsonProperty("seat_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CopilotSeatBreakdown SeatBreakdown { get; set; } = default!;

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_code_suggestions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CopilotOrganizationDetailsPublicCodeSuggestions PublicCodeSuggestions { get; set; } = default!;

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ide_chat")]
        public global::G.CopilotOrganizationDetailsIdeChat? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_chat")]
        public global::G.CopilotOrganizationDetailsPlatformChat? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cli")]
        public global::G.CopilotOrganizationDetailsCli? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seat_management_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CopilotOrganizationDetailsSeatManagementSetting SeatManagementSetting { get; set; } = default!;

        /// <summary>
        /// The Copilot plan of the organization, or the parent enterprise, when applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan_type")]
        public global::G.CopilotOrganizationDetailsPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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