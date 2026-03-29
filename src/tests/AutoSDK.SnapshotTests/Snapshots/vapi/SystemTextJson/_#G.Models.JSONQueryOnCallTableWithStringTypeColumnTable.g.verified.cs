//HintName: G.Models.JSONQueryOnCallTableWithStringTypeColumnTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the table that will be queried.
    /// </summary>
    public enum JSONQueryOnCallTableWithStringTypeColumnTable
    {
        /// <summary>
        /// 
        /// </summary>
        Call,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithStringTypeColumnTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStringTypeColumnTable value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStringTypeColumnTable.Call => "call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStringTypeColumnTable? ToEnum(string value)
        {
            return value switch
            {
                "call" => JSONQueryOnCallTableWithStringTypeColumnTable.Call,
                _ => null,
            };
        }
    }
}