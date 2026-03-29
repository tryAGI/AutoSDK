//HintName: G.Models.LogicalOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ANY = logical OR, ALL = logical AND
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LogicalOp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ALL")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANY")]
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogicalOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogicalOp value)
        {
            return value switch
            {
                LogicalOp.All => "ALL",
                LogicalOp.Any => "ANY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogicalOp? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => LogicalOp.All,
                "ANY" => LogicalOp.Any,
                _ => null,
            };
        }
    }
}