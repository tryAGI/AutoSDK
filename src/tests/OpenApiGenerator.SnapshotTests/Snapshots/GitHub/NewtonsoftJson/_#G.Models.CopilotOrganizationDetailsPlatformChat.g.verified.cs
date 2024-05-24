//HintName: G.Models.CopilotOrganizationDetailsPlatformChat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing organization members to use Copilot features within github.com.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CopilotOrganizationDetailsPlatformChat
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
}