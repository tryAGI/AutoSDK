//HintName: G.Models.RepositoryRuleRequiredDeploymentsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleRequiredDeploymentsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_deployments")]
        RequiredDeployments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleRequiredDeploymentsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleRequiredDeploymentsType value)
        {
            return value switch
            {
                RepositoryRuleRequiredDeploymentsType.RequiredDeployments => "required_deployments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleRequiredDeploymentsType ToEnum(string value)
        {
            return value switch
            {
                "required_deployments" => RepositoryRuleRequiredDeploymentsType.RequiredDeployments,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}