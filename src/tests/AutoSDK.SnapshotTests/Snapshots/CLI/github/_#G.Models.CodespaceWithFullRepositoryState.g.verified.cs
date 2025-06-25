//HintName: G.Models.CodespaceWithFullRepositoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.<br/>
    /// Example: Available
    /// </summary>
    public enum CodespaceWithFullRepositoryState
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Provisioning,
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
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Moved,
        /// <summary>
        /// 
        /// </summary>
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Starting,
        /// <summary>
        /// 
        /// </summary>
        ShuttingDown,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Exporting,
        /// <summary>
        /// 
        /// </summary>
        Updating,
        /// <summary>
        /// 
        /// </summary>
        Rebuilding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespaceWithFullRepositoryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceWithFullRepositoryState value)
        {
            return value switch
            {
                CodespaceWithFullRepositoryState.Unknown => "Unknown",
                CodespaceWithFullRepositoryState.Created => "Created",
                CodespaceWithFullRepositoryState.Queued => "Queued",
                CodespaceWithFullRepositoryState.Provisioning => "Provisioning",
                CodespaceWithFullRepositoryState.Available => "Available",
                CodespaceWithFullRepositoryState.Awaiting => "Awaiting",
                CodespaceWithFullRepositoryState.Unavailable => "Unavailable",
                CodespaceWithFullRepositoryState.Deleted => "Deleted",
                CodespaceWithFullRepositoryState.Moved => "Moved",
                CodespaceWithFullRepositoryState.Shutdown => "Shutdown",
                CodespaceWithFullRepositoryState.Archived => "Archived",
                CodespaceWithFullRepositoryState.Starting => "Starting",
                CodespaceWithFullRepositoryState.ShuttingDown => "ShuttingDown",
                CodespaceWithFullRepositoryState.Failed => "Failed",
                CodespaceWithFullRepositoryState.Exporting => "Exporting",
                CodespaceWithFullRepositoryState.Updating => "Updating",
                CodespaceWithFullRepositoryState.Rebuilding => "Rebuilding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespaceWithFullRepositoryState? ToEnum(string value)
        {
            return value switch
            {
                "Unknown" => CodespaceWithFullRepositoryState.Unknown,
                "Created" => CodespaceWithFullRepositoryState.Created,
                "Queued" => CodespaceWithFullRepositoryState.Queued,
                "Provisioning" => CodespaceWithFullRepositoryState.Provisioning,
                "Available" => CodespaceWithFullRepositoryState.Available,
                "Awaiting" => CodespaceWithFullRepositoryState.Awaiting,
                "Unavailable" => CodespaceWithFullRepositoryState.Unavailable,
                "Deleted" => CodespaceWithFullRepositoryState.Deleted,
                "Moved" => CodespaceWithFullRepositoryState.Moved,
                "Shutdown" => CodespaceWithFullRepositoryState.Shutdown,
                "Archived" => CodespaceWithFullRepositoryState.Archived,
                "Starting" => CodespaceWithFullRepositoryState.Starting,
                "ShuttingDown" => CodespaceWithFullRepositoryState.ShuttingDown,
                "Failed" => CodespaceWithFullRepositoryState.Failed,
                "Exporting" => CodespaceWithFullRepositoryState.Exporting,
                "Updating" => CodespaceWithFullRepositoryState.Updating,
                "Rebuilding" => CodespaceWithFullRepositoryState.Rebuilding,
                _ => null,
            };
        }
    }
}