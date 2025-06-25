//HintName: G.Models.IssuesListForRepoState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum IssuesListForRepoState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForRepoStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForRepoState value)
        {
            return value switch
            {
                IssuesListForRepoState.Open => "open",
                IssuesListForRepoState.Closed => "closed",
                IssuesListForRepoState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForRepoState? ToEnum(string value)
        {
            return value switch
            {
                "open" => IssuesListForRepoState.Open,
                "closed" => IssuesListForRepoState.Closed,
                "all" => IssuesListForRepoState.All,
                _ => null,
            };
        }
    }
}