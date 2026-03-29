//HintName: G.Models.JSONQueryOnCallTableWithNumberTypeColumnOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the aggregation operation to perform on the column.<br/>
    /// When the column is a number type, the operation must be one of the following:<br/>
    /// - average<br/>
    /// - sum<br/>
    /// - min<br/>
    /// - max<br/>
    /// Example: sum
    /// </summary>
    public enum JSONQueryOnCallTableWithNumberTypeColumnOperation
    {
        /// <summary>
        /// 
        /// </summary>
        Average,
        /// <summary>
        /// 
        /// </summary>
        Max,
        /// <summary>
        /// 
        /// </summary>
        Min,
        /// <summary>
        /// 
        /// </summary>
        Sum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithNumberTypeColumnOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithNumberTypeColumnOperation value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithNumberTypeColumnOperation.Average => "average",
                JSONQueryOnCallTableWithNumberTypeColumnOperation.Max => "max",
                JSONQueryOnCallTableWithNumberTypeColumnOperation.Min => "min",
                JSONQueryOnCallTableWithNumberTypeColumnOperation.Sum => "sum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithNumberTypeColumnOperation? ToEnum(string value)
        {
            return value switch
            {
                "average" => JSONQueryOnCallTableWithNumberTypeColumnOperation.Average,
                "max" => JSONQueryOnCallTableWithNumberTypeColumnOperation.Max,
                "min" => JSONQueryOnCallTableWithNumberTypeColumnOperation.Min,
                "sum" => JSONQueryOnCallTableWithNumberTypeColumnOperation.Sum,
                _ => null,
            };
        }
    }
}