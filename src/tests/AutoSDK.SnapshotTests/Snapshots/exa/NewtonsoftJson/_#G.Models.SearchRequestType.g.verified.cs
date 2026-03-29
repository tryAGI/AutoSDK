//HintName: G.Models.SearchRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines available search methods, fast uses streamlined versions of the neural model, and deep provides comprehensive search with query expansion and detailed context.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deep")]
        Deep,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neural")]
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestType value)
        {
            return value switch
            {
                SearchRequestType.Auto => "auto",
                SearchRequestType.Deep => "deep",
                SearchRequestType.Fast => "fast",
                SearchRequestType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SearchRequestType.Auto,
                "deep" => SearchRequestType.Deep,
                "fast" => SearchRequestType.Fast,
                "neural" => SearchRequestType.Neural,
                _ => null,
            };
        }
    }
}