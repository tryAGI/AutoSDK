//HintName: G.Models.UsageModerationsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageModerationsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.moderations.result")]
        OrganizationUsageModerationsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageModerationsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageModerationsResultObject value)
        {
            return value switch
            {
                UsageModerationsResultObject.OrganizationUsageModerationsResult => "organization.usage.moderations.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageModerationsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.moderations.result" => UsageModerationsResultObject.OrganizationUsageModerationsResult,
                _ => null,
            };
        }
    }
}