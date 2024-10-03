//HintName: G.Models.GithubRepositoryOutType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: github
    /// </summary>
    public enum GithubRepositoryOutType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GithubRepositoryOutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GithubRepositoryOutType value)
        {
            return value switch
            {
                GithubRepositoryOutType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GithubRepositoryOutType? ToEnum(string value)
        {
            return value switch
            {
                "github" => GithubRepositoryOutType.Github,
                _ => null,
            };
        }
    }
}