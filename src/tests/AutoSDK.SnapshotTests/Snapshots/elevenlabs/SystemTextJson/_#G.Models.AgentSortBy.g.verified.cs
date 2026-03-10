//HintName: G.Models.AgentSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSortBy value)
        {
            return value switch
            {
                AgentSortBy.Name => "name",
                AgentSortBy.CreatedAt => "created_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSortBy? ToEnum(string value)
        {
            return value switch
            {
                "name" => AgentSortBy.Name,
                "created_at" => AgentSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}