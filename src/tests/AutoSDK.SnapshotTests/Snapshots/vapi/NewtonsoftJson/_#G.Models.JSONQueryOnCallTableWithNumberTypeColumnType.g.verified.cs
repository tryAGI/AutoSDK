//HintName: G.Models.JSONQueryOnCallTableWithNumberTypeColumnType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of query. Only allowed type is "vapiql-json".<br/>
    /// Example: vapiql-json
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnCallTableWithNumberTypeColumnType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vapiql-json")]
        VapiqlJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnCallTableWithNumberTypeColumnTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnCallTableWithNumberTypeColumnType value)
        {
            return value switch
            {
                JSONQueryOnCallTableWithNumberTypeColumnType.VapiqlJson => "vapiql-json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnCallTableWithNumberTypeColumnType? ToEnum(string value)
        {
            return value switch
            {
                "vapiql-json" => JSONQueryOnCallTableWithNumberTypeColumnType.VapiqlJson,
                _ => null,
            };
        }
    }
}