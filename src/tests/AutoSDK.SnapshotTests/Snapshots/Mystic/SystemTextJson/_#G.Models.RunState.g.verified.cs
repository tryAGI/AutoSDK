//HintName: G.Models.RunState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum RunState
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Routing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NoResourcesAvailable,
        /// <summary>
        /// 
        /// </summary>
        NodePreempted,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunState value)
        {
            return value switch
            {
                RunState.Created => "created",
                RunState.Routing => "routing",
                RunState.Queued => "queued",
                RunState.Running => "running",
                RunState.Completed => "completed",
                RunState.Failed => "failed",
                RunState.NoResourcesAvailable => "no_resources_available",
                RunState.NodePreempted => "node_preempted",
                RunState.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunState? ToEnum(string value)
        {
            return value switch
            {
                "created" => RunState.Created,
                "routing" => RunState.Routing,
                "queued" => RunState.Queued,
                "running" => RunState.Running,
                "completed" => RunState.Completed,
                "failed" => RunState.Failed,
                "no_resources_available" => RunState.NoResourcesAvailable,
                "node_preempted" => RunState.NodePreempted,
                "unknown" => RunState.Unknown,
                _ => null,
            };
        }
    }
}