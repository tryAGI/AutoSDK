//HintName: G.Models.CopilotOrganizationDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the seat breakdown and policies set for an organization with a Copilot Business subscription.
    /// </summary>
    public sealed partial class CopilotOrganizationDetails
    {
        /// <summary>
        /// The breakdown of Copilot Business seats for the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seat_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public CopilotSeatBreakdown SeatBreakdown { get; set; } = default!;

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public_code_suggestions", Required = global::Newtonsoft.Json.Required.Always)]
        public CopilotOrganizationDetailsPublicCodeSuggestions PublicCodeSuggestions { get; set; } = default!;

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ide_chat")]
        public CopilotOrganizationDetailsIdeChat? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("platform_chat")]
        public CopilotOrganizationDetailsPlatformChat? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cli")]
        public CopilotOrganizationDetailsCli? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seat_management_setting", Required = global::Newtonsoft.Json.Required.Always)]
        public CopilotOrganizationDetailsSeatManagementSetting SeatManagementSetting { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}