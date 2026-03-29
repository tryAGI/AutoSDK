//HintName: G.Models.RequestClickhouseFilterBranchOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestClickhouseFilterBranchOperator
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
    public static class RequestClickhouseFilterBranchOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestClickhouseFilterBranchOperator value)
        {
            return value switch
            {
                RequestClickhouseFilterBranchOperator.And => "and",
                RequestClickhouseFilterBranchOperator.Or => "or",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestClickhouseFilterBranchOperator? ToEnum(string value)
        {
            return value switch
            {
                "and" => RequestClickhouseFilterBranchOperator.And,
                "or" => RequestClickhouseFilterBranchOperator.Or,
                _ => null,
            };
        }
    }
}