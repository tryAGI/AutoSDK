//HintName: G.Models.CopilotOrganizationDetailsPlatformChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
    /// </summary>
    public enum CopilotOrganizationDetailsPlatformChat
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
    public static class CopilotOrganizationDetailsPlatformChatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsPlatformChat value)
        {
            return value switch
            {
                CopilotOrganizationDetailsPlatformChat.Enabled => "enabled",
                CopilotOrganizationDetailsPlatformChat.Disabled => "disabled",
                CopilotOrganizationDetailsPlatformChat.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsPlatformChat ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CopilotOrganizationDetailsPlatformChat.Enabled,
                "disabled" => CopilotOrganizationDetailsPlatformChat.Disabled,
                "unconfigured" => CopilotOrganizationDetailsPlatformChat.Unconfigured,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}