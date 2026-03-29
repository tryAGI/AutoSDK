//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant5ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsResponseConnectionDataVariant5ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}