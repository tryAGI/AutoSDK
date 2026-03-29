//HintName: G.Models.AgentsSearchDeployedAgentsRequestSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsSearchDeployedAgentsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        LastRunCompletion,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSortBy value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSortBy.CreatedAt => "created_at",
                AgentsSearchDeployedAgentsRequestSortBy.LastRunCompletion => "last_run_completion",
                AgentsSearchDeployedAgentsRequestSortBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentsSearchDeployedAgentsRequestSortBy.CreatedAt,
                "last_run_completion" => AgentsSearchDeployedAgentsRequestSortBy.LastRunCompletion,
                "updated_at" => AgentsSearchDeployedAgentsRequestSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}