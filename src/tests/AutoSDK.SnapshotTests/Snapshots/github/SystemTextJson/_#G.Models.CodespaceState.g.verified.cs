//HintName: G.Models.CodespaceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.<br/>
    /// Example: Available
    /// </summary>
    public enum CodespaceState
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Available,
        /// <summary>
        /// 
        /// </summary>
        Awaiting,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Exporting,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Moved,
        /// <summary>
        /// 
        /// </summary>
        Provisioning,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Rebuilding,
        /// <summary>
        /// 
        /// </summary>
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        ShuttingDown,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Updating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespaceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceState value)
        {
            return value switch
            {
                CodespaceState.Archived => "Archived",
                CodespaceState.Available => "Available",
                CodespaceState.Awaiting => "Awaiting",
                CodespaceState.Created => "Created",
                CodespaceState.Deleted => "Deleted",
                CodespaceState.Exporting => "Exporting",
                CodespaceState.Failed => "Failed",
                CodespaceState.Moved => "Moved",
                CodespaceState.Provisioning => "Provisioning",
                CodespaceState.Queued => "Queued",
                CodespaceState.Rebuilding => "Rebuilding",
                CodespaceState.Shutdown => "Shutdown",
                CodespaceState.ShuttingDown => "ShuttingDown",
                CodespaceState.Starting => "Starting",
                CodespaceState.Unavailable => "Unavailable",
                CodespaceState.Unknown => "Unknown",
                CodespaceState.Updating => "Updating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespaceState? ToEnum(string value)
        {
            return value switch
            {
                "Archived" => CodespaceState.Archived,
                "Available" => CodespaceState.Available,
                "Awaiting" => CodespaceState.Awaiting,
                "Created" => CodespaceState.Created,
                "Deleted" => CodespaceState.Deleted,
                "Exporting" => CodespaceState.Exporting,
                "Failed" => CodespaceState.Failed,
                "Moved" => CodespaceState.Moved,
                "Provisioning" => CodespaceState.Provisioning,
                "Queued" => CodespaceState.Queued,
                "Rebuilding" => CodespaceState.Rebuilding,
                "Shutdown" => CodespaceState.Shutdown,
                "ShuttingDown" => CodespaceState.ShuttingDown,
                "Starting" => CodespaceState.Starting,
                "Unavailable" => CodespaceState.Unavailable,
                "Unknown" => CodespaceState.Unknown,
                "Updating" => CodespaceState.Updating,
                _ => null,
            };
        }
    }
}