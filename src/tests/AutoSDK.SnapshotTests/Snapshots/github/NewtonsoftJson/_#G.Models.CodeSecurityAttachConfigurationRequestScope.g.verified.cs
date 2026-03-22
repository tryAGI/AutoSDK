//HintName: G.Models.CodeSecurityAttachConfigurationRequestScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories to attach the configuration to. `selected` means the configuration will be attached to only the repositories specified by `selected_repository_ids`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityAttachConfigurationRequestScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private_or_internal")]
        PrivateOrInternal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityAttachConfigurationRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityAttachConfigurationRequestScope value)
        {
            return value switch
            {
                CodeSecurityAttachConfigurationRequestScope.All => "all",
                CodeSecurityAttachConfigurationRequestScope.PrivateOrInternal => "private_or_internal",
                CodeSecurityAttachConfigurationRequestScope.Public => "public",
                CodeSecurityAttachConfigurationRequestScope.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityAttachConfigurationRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecurityAttachConfigurationRequestScope.All,
                "private_or_internal" => CodeSecurityAttachConfigurationRequestScope.PrivateOrInternal,
                "public" => CodeSecurityAttachConfigurationRequestScope.Public,
                "selected" => CodeSecurityAttachConfigurationRequestScope.Selected,
                _ => null,
            };
        }
    }
}