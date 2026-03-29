//HintName: G.Models.JSONQueryOnCallTableWithNumberTypeColumnTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the table that will be queried.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithNumberTypeColumnTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call")]
        Call,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithNumberTypeColumnTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithNumberTypeColumnTable value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithNumberTypeColumnTable.Call => "call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithNumberTypeColumnTable? ToEnum(string value)
        {
            return value switch
            {
                "call" => JSONQueryOnCallTableWithNumberTypeColumnTable.Call,
                _ => null,
            };
        }
    }
}