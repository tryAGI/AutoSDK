//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant4ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsResponseConnectionDataVariant4ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}