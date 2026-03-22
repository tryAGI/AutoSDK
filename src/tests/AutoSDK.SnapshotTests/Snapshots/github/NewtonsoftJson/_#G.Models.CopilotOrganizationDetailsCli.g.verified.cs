//HintName: G.Models.CopilotOrganizationDetailsCli.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing organization members to use Copilot within their CLI.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CopilotOrganizationDetailsCli
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unconfigured")]
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
                CopilotOrganizationDetailsCli.Disabled => "disabled",
                CopilotOrganizationDetailsCli.Enabled => "enabled",
                CopilotOrganizationDetailsCli.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsCli? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CopilotOrganizationDetailsCli.Disabled,
                "enabled" => CopilotOrganizationDetailsCli.Enabled,
                "unconfigured" => CopilotOrganizationDetailsCli.Unconfigured,
                _ => null,
            };
        }
    }
}