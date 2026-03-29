//HintName: G.Models.JSONQueryOnCallTableWithStringTypeColumnOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the aggregation operation to perform on the column.<br/>
    /// When the column is a string type, the operation must be "count".<br/>
    /// Example: count
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithStringTypeColumnOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="count")]
        Count,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithStringTypeColumnOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStringTypeColumnOperation value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStringTypeColumnOperation.Count => "count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStringTypeColumnOperation? ToEnum(string value)
        {
            return value switch
            {
                "count" => JSONQueryOnCallTableWithStringTypeColumnOperation.Count,
                _ => null,
            };
        }
    }
}