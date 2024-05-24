//HintName: G.Models.CopilotOrganizationDetailsPublicCodeSuggestions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The organization policy for allowing or disallowing Copilot to make suggestions that match public code.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CopilotOrganizationDetailsPublicCodeSuggestions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allow")]
        Allow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="block")]
        Block,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unconfigured")]
        Unconfigured,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }
}