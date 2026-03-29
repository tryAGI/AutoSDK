//HintName: G.Models.AgentsSearchDeployedAgentsRequestSortBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsSearchDeployedAgentsRequestSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_run_completion")]
        LastRunCompletion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated_at")]
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