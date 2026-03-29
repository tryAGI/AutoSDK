//HintName: G.Models.JSONQueryOnCallTableWithStructuredOutputColumnTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the table that will be queried.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithStructuredOutputColumnTable
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
    public static class JSONQueryOnCallTableWithStructuredOutputColumnTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithStructuredOutputColumnTable value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithStructuredOutputColumnTable.Call => "call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithStructuredOutputColumnTable? ToEnum(string value)
        {
            return value switch
            {
                "call" => JSONQueryOnCallTableWithStructuredOutputColumnTable.Call,
                _ => null,
            };
        }
    }
}