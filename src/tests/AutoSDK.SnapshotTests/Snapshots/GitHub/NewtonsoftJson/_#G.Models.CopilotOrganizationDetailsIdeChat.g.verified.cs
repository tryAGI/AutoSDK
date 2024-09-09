//HintName: G.Models.CopilotOrganizationDetailsIdeChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing organization members to use Copilot Chat within their editor.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CopilotOrganizationDetailsIdeChat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unconfigured")]
        Unconfigured,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotOrganizationDetailsIdeChatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotOrganizationDetailsIdeChat value)
        {
            return value switch
            {
                CopilotOrganizationDetailsIdeChat.Enabled => "enabled",
                CopilotOrganizationDetailsIdeChat.Disabled => "disabled",
                CopilotOrganizationDetailsIdeChat.Unconfigured => "unconfigured",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotOrganizationDetailsIdeChat? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CopilotOrganizationDetailsIdeChat.Enabled,
                "disabled" => CopilotOrganizationDetailsIdeChat.Disabled,
                "unconfigured" => CopilotOrganizationDetailsIdeChat.Unconfigured,
                _ => null,
            };
        }
    }
}