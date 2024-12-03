//HintName: G.Models.RepositoryRuleRequiredStatusChecksType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleRequiredStatusChecksType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_status_checks")]
        RequiredStatusChecks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleRequiredStatusChecksTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleRequiredStatusChecksType value)
        {
            return value switch
            {
                RepositoryRuleRequiredStatusChecksType.RequiredStatusChecks => "required_status_checks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleRequiredStatusChecksType? ToEnum(string value)
        {
            return value switch
            {
                "required_status_checks" => RepositoryRuleRequiredStatusChecksType.RequiredStatusChecks,
                _ => null,
            };
        }
    }
}