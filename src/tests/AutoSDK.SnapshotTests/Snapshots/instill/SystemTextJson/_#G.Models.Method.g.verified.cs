//HintName: G.Models.Method.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Method defines how the connection is set up.<br/>
    ///  - METHOD_DICTIONARY: Key-value collection. The user is responsible of fetching the connection<br/>
    /// details from the 3rd party service.<br/>
    ///  - METHOD_OAUTH: Access token created via OAuth 2.0 authorization.
    /// </summary>
    public enum Method
    {
        /// <summary>
        /// Key-value collection. The user is responsible of fetching the connection
        /// </summary>
        DICTIONARY,
        /// <summary>
        /// Access token created via OAuth 2.0 authorization.
        /// </summary>
        OAUTH,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Method value)
        {
            return value switch
            {
                Method.DICTIONARY => "METHOD_DICTIONARY",
                Method.OAUTH => "METHOD_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Method? ToEnum(string value)
        {
            return value switch
            {
                "METHOD_DICTIONARY" => Method.DICTIONARY,
                "METHOD_OAUTH" => Method.OAUTH,
                _ => null,
            };
        }
    }
}