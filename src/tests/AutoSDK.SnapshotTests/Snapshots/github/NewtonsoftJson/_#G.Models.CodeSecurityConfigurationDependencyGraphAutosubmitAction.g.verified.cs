//HintName: G.Models.CodeSecurityConfigurationDependencyGraphAutosubmitAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Automatic dependency submission
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationDependencyGraphAutosubmitAction
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
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationDependencyGraphAutosubmitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationDependencyGraphAutosubmitAction value)
        {
            return value switch
            {
                CodeSecurityConfigurationDependencyGraphAutosubmitAction.Enabled => "enabled",
                CodeSecurityConfigurationDependencyGraphAutosubmitAction.Disabled => "disabled",
                CodeSecurityConfigurationDependencyGraphAutosubmitAction.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationDependencyGraphAutosubmitAction? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationDependencyGraphAutosubmitAction.Enabled,
                "disabled" => CodeSecurityConfigurationDependencyGraphAutosubmitAction.Disabled,
                "not_set" => CodeSecurityConfigurationDependencyGraphAutosubmitAction.NotSet,
                _ => null,
            };
        }
    }
}