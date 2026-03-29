//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant4AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant4AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant4AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant4AuthScheme.Basic => "BASIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => PostConnectedAccountsRequestConnectionStateVariant4AuthScheme.Basic,
                _ => null,
            };
        }
    }
}