//HintName: G.Models.CodespaceWithFullRepositoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.<br/>
    /// Example: Available
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceWithFullRepositoryState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Archived")]
        Archived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Available")]
        Available,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Awaiting")]
        Awaiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Exporting")]
        Exporting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Moved")]
        Moved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Provisioning")]
        Provisioning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rebuilding")]
        Rebuilding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Shutdown")]
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ShuttingDown")]
        ShuttingDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Starting")]
        Starting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unavailable")]
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Updating")]
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