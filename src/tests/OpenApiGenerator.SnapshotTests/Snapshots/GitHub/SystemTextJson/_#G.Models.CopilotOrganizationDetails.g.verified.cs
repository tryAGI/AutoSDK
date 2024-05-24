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
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required CopilotSeatBreakdown SeatBreakdown { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_code_suggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicCodeSuggestions { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ide_chat")]
        public string? IdeChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform_chat")]
        public string? PlatformChat { get; set; }

        /// <summary>
        /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cli")]
        public string? Cli { get; set; }

        /// <summary>
        /// The mode of assigning new seats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_management_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeatManagementSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}