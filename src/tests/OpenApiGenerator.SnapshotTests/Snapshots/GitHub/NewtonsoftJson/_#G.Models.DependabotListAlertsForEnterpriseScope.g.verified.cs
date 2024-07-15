//HintName: G.Models.DependabotListAlertsForEnterpriseScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotListAlertsForEnterpriseScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="development")]
        Development,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runtime")]
        Runtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotListAlertsForEnterpriseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForEnterpriseScope value)
        {
            return value switch
            {
                DependabotListAlertsForEnterpriseScope.Development => "development",
                DependabotListAlertsForEnterpriseScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForEnterpriseScope? ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotListAlertsForEnterpriseScope.Development,
                "runtime" => DependabotListAlertsForEnterpriseScope.Runtime,
                _ => null,
            };
        }
    }
}