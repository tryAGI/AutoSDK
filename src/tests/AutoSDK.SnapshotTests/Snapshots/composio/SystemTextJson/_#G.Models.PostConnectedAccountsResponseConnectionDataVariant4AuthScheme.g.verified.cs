//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant4AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant4AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant4AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant4AuthScheme.Basic => "BASIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => PostConnectedAccountsResponseConnectionDataVariant4AuthScheme.Basic,
                _ => null,
            };
        }
    }
}