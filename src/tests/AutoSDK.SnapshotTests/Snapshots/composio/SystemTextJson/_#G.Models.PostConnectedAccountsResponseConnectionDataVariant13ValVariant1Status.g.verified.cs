//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant13ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => PostConnectedAccountsResponseConnectionDataVariant13ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}