//HintName: G.Models.ListInternalRunsDurationOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListInternalRunsDurationOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Lt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListInternalRunsDurationOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternalRunsDurationOperator value)
        {
            return value switch
            {
                ListInternalRunsDurationOperator.Eq => "eq",
                ListInternalRunsDurationOperator.Gt => "gt",
                ListInternalRunsDurationOperator.Lt => "lt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternalRunsDurationOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ListInternalRunsDurationOperator.Eq,
                "gt" => ListInternalRunsDurationOperator.Gt,
                "lt" => ListInternalRunsDurationOperator.Lt,
                _ => null,
            };
        }
    }
}