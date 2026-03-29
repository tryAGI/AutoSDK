//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant9ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => PostConnectedAccountsResponseConnectionDataVariant9ValVariant5Status.Failed,
                _ => null,
            };
        }
    }
}