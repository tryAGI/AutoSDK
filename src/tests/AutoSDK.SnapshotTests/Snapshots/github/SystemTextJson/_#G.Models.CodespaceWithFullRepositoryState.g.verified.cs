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
    public static class CodespaceWithFullRepositoryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceWithFullRepositoryState value)
        {
            return value switch
            {
                CodespaceWithFullRepositoryState.Archived => "Archived",
                CodespaceWithFullRepositoryState.Available => "Available",
                CodespaceWithFullRepositoryState.Awaiting => "Awaiting",
                CodespaceWithFullRepositoryState.Created => "Created",
                CodespaceWithFullRepositoryState.Deleted => "Deleted",
                CodespaceWithFullRepositoryState.Exporting => "Exporting",
                CodespaceWithFullRepositoryState.Failed => "Failed",
                CodespaceWithFullRepositoryState.Moved => "Moved",
                CodespaceWithFullRepositoryState.Provisioning => "Provisioning",
                CodespaceWithFullRepositoryState.Queued => "Queued",
                CodespaceWithFullRepositoryState.Rebuilding => "Rebuilding",
                CodespaceWithFullRepositoryState.Shutdown => "Shutdown",
                CodespaceWithFullRepositoryState.ShuttingDown => "ShuttingDown",
                CodespaceWithFullRepositoryState.Starting => "Starting",
                CodespaceWithFullRepositoryState.Unavailable => "Unavailable",
                CodespaceWithFullRepositoryState.Unknown => "Unknown",
                CodespaceWithFullRepositoryState.Updating => "Updating",
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
                "Archived" => CodespaceWithFullRepositoryState.Archived,
                "Available" => CodespaceWithFullRepositoryState.Available,
                "Awaiting" => CodespaceWithFullRepositoryState.Awaiting,
                "Created" => CodespaceWithFullRepositoryState.Created,
                "Deleted" => CodespaceWithFullRepositoryState.Deleted,
                "Exporting" => CodespaceWithFullRepositoryState.Exporting,
                "Failed" => CodespaceWithFullRepositoryState.Failed,
                "Moved" => CodespaceWithFullRepositoryState.Moved,
                "Provisioning" => CodespaceWithFullRepositoryState.Provisioning,
                "Queued" => CodespaceWithFullRepositoryState.Queued,
                "Rebuilding" => CodespaceWithFullRepositoryState.Rebuilding,
                "Shutdown" => CodespaceWithFullRepositoryState.Shutdown,
                "ShuttingDown" => CodespaceWithFullRepositoryState.ShuttingDown,
                "Starting" => CodespaceWithFullRepositoryState.Starting,
                "Unavailable" => CodespaceWithFullRepositoryState.Unavailable,
                "Unknown" => CodespaceWithFullRepositoryState.Unknown,
                "Updating" => CodespaceWithFullRepositoryState.Updating,
                _ => null,
            };
        }
    }
}