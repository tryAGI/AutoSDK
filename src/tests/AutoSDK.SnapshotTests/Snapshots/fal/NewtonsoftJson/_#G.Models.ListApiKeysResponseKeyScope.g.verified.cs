//HintName: G.Models.ListApiKeysResponseKeyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scope of the API key. Only API scope keys can be managed via this API.<br/>
    /// Example: API
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListApiKeysResponseKeyScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API")]
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListApiKeysResponseKeyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseKeyScope value)
        {
            return value switch
            {
                ListApiKeysResponseKeyScope.Api => "API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseKeyScope? ToEnum(string value)
        {
            return value switch
            {
                "API" => ListApiKeysResponseKeyScope.Api,
                _ => null,
            };
        }
    }
}