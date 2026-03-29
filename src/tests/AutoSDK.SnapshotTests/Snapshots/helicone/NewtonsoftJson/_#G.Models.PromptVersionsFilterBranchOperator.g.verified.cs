//HintName: G.Models.PromptVersionsFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionsFilterBranchOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="and")]
        And,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="or")]
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionsFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionsFilterBranchOperator value)
        {
            return value switch
            {
                PromptVersionsFilterBranchOperator.And => "and",
                PromptVersionsFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionsFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => PromptVersionsFilterBranchOperator.And,
                "or" => PromptVersionsFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}