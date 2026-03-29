//HintName: G.Models.NumberFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// eq: equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NumberFilterOp
    {
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ge")]
        Ge,
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="le")]
        Le,
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// equal, ne: not equal, gt: greater than, ge: greater than or equal, lt: less than, le: less than or equal
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ne")]
        Ne,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NumberFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NumberFilterOp value)
        {
            return value switch
            {
                NumberFilterOp.Eq => "eq",
                NumberFilterOp.Ge => "ge",
                NumberFilterOp.Gt => "gt",
                NumberFilterOp.Le => "le",
                NumberFilterOp.Lt => "lt",
                NumberFilterOp.Ne => "ne",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NumberFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "eq" => NumberFilterOp.Eq,
                "ge" => NumberFilterOp.Ge,
                "gt" => NumberFilterOp.Gt,
                "le" => NumberFilterOp.Le,
                "lt" => NumberFilterOp.Lt,
                "ne" => NumberFilterOp.Ne,
                _ => null,
            };
        }
    }
}