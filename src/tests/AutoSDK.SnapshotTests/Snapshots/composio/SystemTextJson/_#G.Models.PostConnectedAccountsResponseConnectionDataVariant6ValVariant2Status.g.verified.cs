//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant6ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => PostConnectedAccountsResponseConnectionDataVariant6ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}