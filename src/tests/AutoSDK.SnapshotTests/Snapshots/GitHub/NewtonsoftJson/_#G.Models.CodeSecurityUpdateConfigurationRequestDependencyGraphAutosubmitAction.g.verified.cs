//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Automatic dependency submission
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction
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
    public static class CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction.NotSet,
                _ => null,
            };
        }
    }
}