//HintName: G.Models.GroupConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the logical operator for combining conditions in this group
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GroupConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AND")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OR")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupConditionOperator value)
        {
            return value switch
            {
                GroupConditionOperator.And => "AND",
                GroupConditionOperator.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "AND" => GroupConditionOperator.And,
                "OR" => GroupConditionOperator.Or,
                _ => null,
            };
        }
    }
}