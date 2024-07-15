//HintName: G.Models.RepositoryRuleRequiredLinearHistoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRuleRequiredLinearHistoryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="required_linear_history")]
        RequiredLinearHistory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleRequiredLinearHistoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleRequiredLinearHistoryType value)
        {
            return value switch
            {
                RepositoryRuleRequiredLinearHistoryType.RequiredLinearHistory => "required_linear_history",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleRequiredLinearHistoryType? ToEnum(string value)
        {
            return value switch
            {
                "required_linear_history" => RepositoryRuleRequiredLinearHistoryType.RequiredLinearHistory,
                _ => null,
            };
        }
    }
}