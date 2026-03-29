//HintName: G.Models.JSONQueryOnCallTableWithStructuredOutputColumnOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the aggregation operation to perform on the column.<br/>
    /// When the column is a structured output type, the operation depends on the value of the structured output.<br/>
    /// If the structured output is a string or boolean, the operation must be "count".<br/>
    /// If the structured output is a number, the operation can be "average", "sum", "min", or "max".<br/>
    /// Example: count
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithStructuredOutputColumnOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="average")]
        Average,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="count")]
        Count,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max")]
        Max,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="min")]
        Min,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sum")]
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithStructuredOutputColumnOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStructuredOutputColumnOperation value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStructuredOutputColumnOperation.Average => "average",
                JSONQueryOnCallTableWithStructuredOutputColumnOperation.Count => "count",
                JSONQueryOnCallTableWithStructuredOutputColumnOperation.Max => "max",
                JSONQueryOnCallTableWithStructuredOutputColumnOperation.Min => "min",
                JSONQueryOnCallTableWithStructuredOutputColumnOperation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStructuredOutputColumnOperation? ToEnum(string value)
        {
            return value switch
            {
                "average" => JSONQueryOnCallTableWithStructuredOutputColumnOperation.Average,
                "count" => JSONQueryOnCallTableWithStructuredOutputColumnOperation.Count,
                "max" => JSONQueryOnCallTableWithStructuredOutputColumnOperation.Max,
                "min" => JSONQueryOnCallTableWithStructuredOutputColumnOperation.Min,
                "sum" => JSONQueryOnCallTableWithStructuredOutputColumnOperation.Sum,
                _ => null,
            };
        }
    }
}