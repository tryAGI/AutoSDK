//HintName: G.Models.FilterCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vector store filter conditions to combine different filters.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not")]
        Not,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterConditionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterCondition value)
        {
            return value switch
            {
                FilterCondition.And => "and",
                FilterCondition.Not => "not",
                FilterCondition.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterCondition? ToEnum(string value)
        {
            return value switch
            {
                "and" => FilterCondition.And,
                "not" => FilterCondition.Not,
                "or" => FilterCondition.Or,
                _ => null,
            };
        }
    }
}