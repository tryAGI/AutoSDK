//HintName: G.Models.CodespacesSecretVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories in the organization that the secret is visible to
    /// </summary>
    public enum CodespacesSecretVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespacesSecretVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesSecretVisibility value)
        {
            return value switch
            {
                CodespacesSecretVisibility.All => "all",
                CodespacesSecretVisibility.Private => "private",
                CodespacesSecretVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesSecretVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodespacesSecretVisibility.All,
                "private" => CodespacesSecretVisibility.Private,
                "selected" => CodespacesSecretVisibility.Selected,
                _ => null,
            };
        }
    }
}