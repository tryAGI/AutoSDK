//HintName: G.Models.IssuesListForOrgState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: open
    /// </summary>
    public enum IssuesListForOrgState
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssuesListForOrgStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssuesListForOrgState value)
        {
            return value switch
            {
                IssuesListForOrgState.All => "all",
                IssuesListForOrgState.Closed => "closed",
                IssuesListForOrgState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssuesListForOrgState? ToEnum(string value)
        {
            return value switch
            {
                "all" => IssuesListForOrgState.All,
                "closed" => IssuesListForOrgState.Closed,
                "open" => IssuesListForOrgState.Open,
                _ => null,
            };
        }
    }
}