//HintName: G.Models.EnabledRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
    /// </summary>
    public enum EnabledRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnabledRepositories value)
        {
            return value switch
            {
                EnabledRepositories.All => "all",
                EnabledRepositories.None => "none",
                EnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnabledRepositories? ToEnum(string value)
        {
            return value switch
            {
                "all" => EnabledRepositories.All,
                "none" => EnabledRepositories.None,
                "selected" => EnabledRepositories.Selected,
                _ => null,
            };
        }
    }
}