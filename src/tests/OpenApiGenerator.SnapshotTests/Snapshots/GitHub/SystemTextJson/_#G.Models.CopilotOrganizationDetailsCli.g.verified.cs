//HintName: G.Models.CopilotOrganizationDetailsCli.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
    /// </summary>
    public enum CopilotOrganizationDetailsCli
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Unconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsCliExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsCli value)
        {
            return value switch
            {
                CopilotOrganizationDetailsCli.Enabled => "enabled",
                CopilotOrganizationDetailsCli.Disabled => "disabled",
                CopilotOrganizationDetailsCli.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsCli ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CopilotOrganizationDetailsCli.Enabled,
                "disabled" => CopilotOrganizationDetailsCli.Disabled,
                "unconfigured" => CopilotOrganizationDetailsCli.Unconfigured,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}