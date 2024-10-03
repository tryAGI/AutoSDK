//HintName: G.Models.GithubRepositoryInType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: github
    /// </summary>
    public enum GithubRepositoryInType
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GithubRepositoryInTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GithubRepositoryInType value)
        {
            return value switch
            {
                GithubRepositoryInType.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GithubRepositoryInType? ToEnum(string value)
        {
            return value switch
            {
                "github" => GithubRepositoryInType.Github,
                _ => null,
            };
        }
    }
}