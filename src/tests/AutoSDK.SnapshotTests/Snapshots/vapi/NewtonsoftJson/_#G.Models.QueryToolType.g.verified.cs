//HintName: G.Models.QueryToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "query" for Query tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum QueryToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryToolType value)
        {
            return value switch
            {
                QueryToolType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryToolType? ToEnum(string value)
        {
            return value switch
            {
                "query" => QueryToolType.Query,
                _ => null,
            };
        }
    }
}