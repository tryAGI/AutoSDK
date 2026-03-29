//HintName: G.Models.ListInternalRunsDurationOperator2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListInternalRunsDurationOperator2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInternalRunsDurationOperator2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternalRunsDurationOperator2 value)
        {
            return value switch
            {
                ListInternalRunsDurationOperator2.Eq => "eq",
                ListInternalRunsDurationOperator2.Gt => "gt",
                ListInternalRunsDurationOperator2.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternalRunsDurationOperator2? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ListInternalRunsDurationOperator2.Eq,
                "gt" => ListInternalRunsDurationOperator2.Gt,
                "lt" => ListInternalRunsDurationOperator2.Lt,
                _ => null,
            };
        }
    }
}