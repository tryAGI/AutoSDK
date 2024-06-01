//HintName: G.Models.CodespaceWithFullRepositoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.
    /// <br/>Example: Available
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceWithFullRepositoryState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unknown")]
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Provisioning")]
        Provisioning,
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
        [global::System.Runtime.Serialization.EnumMember(Value="Unavailable")]
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Moved")]
        Moved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Shutdown")]
        Shutdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Archived")]
        Archived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Starting")]
        Starting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ShuttingDown")]
        ShuttingDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Exporting")]
        Exporting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Updating")]
        Updating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Rebuilding")]
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
        public static CodespaceWithFullRepositoryState ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}