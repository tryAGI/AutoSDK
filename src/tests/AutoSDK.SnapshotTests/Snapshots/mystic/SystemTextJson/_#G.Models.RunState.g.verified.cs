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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
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
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Routing,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
                RunState.Completed => "completed",
                RunState.Created => "created",
                RunState.Failed => "failed",
                RunState.NoResourcesAvailable => "no_resources_available",
                RunState.NodePreempted => "node_preempted",
                RunState.Queued => "queued",
                RunState.Routing => "routing",
                RunState.Running => "running",
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
                "completed" => RunState.Completed,
                "created" => RunState.Created,
                "failed" => RunState.Failed,
                "no_resources_available" => RunState.NoResourcesAvailable,
                "node_preempted" => RunState.NodePreempted,
                "queued" => RunState.Queued,
                "routing" => RunState.Routing,
                "running" => RunState.Running,
                "unknown" => RunState.Unknown,
                _ => null,
            };
        }
    }
}