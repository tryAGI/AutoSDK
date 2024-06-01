//HintName: G.Models.ReposListForAuthenticatedUserVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    public enum ReposListForAuthenticatedUserVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForAuthenticatedUserVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForAuthenticatedUserVisibility value)
        {
            return value switch
            {
                ReposListForAuthenticatedUserVisibility.All => "all",
                ReposListForAuthenticatedUserVisibility.Public => "public",
                ReposListForAuthenticatedUserVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForAuthenticatedUserVisibility ToEnum(string value)
        {
            return value switch
            {
                "all" => ReposListForAuthenticatedUserVisibility.All,
                "public" => ReposListForAuthenticatedUserVisibility.Public,
                "private" => ReposListForAuthenticatedUserVisibility.Private,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}