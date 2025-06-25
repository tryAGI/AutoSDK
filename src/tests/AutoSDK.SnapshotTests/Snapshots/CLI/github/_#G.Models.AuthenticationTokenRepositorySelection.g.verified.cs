//HintName: G.Models.AuthenticationTokenRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    public enum AuthenticationTokenRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationTokenRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationTokenRepositorySelection value)
        {
            return value switch
            {
                AuthenticationTokenRepositorySelection.All => "all",
                AuthenticationTokenRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationTokenRepositorySelection? ToEnum(string value)
        {
            return value switch
            {
                "all" => AuthenticationTokenRepositorySelection.All,
                "selected" => AuthenticationTokenRepositorySelection.Selected,
                _ => null,
            };
        }
    }
}