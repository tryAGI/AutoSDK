//HintName: G.Models.CodespaceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.
    /// <br/>Example: Available
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceState
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
    public static class CodespaceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespaceState value)
        {
            return value switch
            {
                CodespaceState.Unknown => "Unknown",
                CodespaceState.Created => "Created",
                CodespaceState.Queued => "Queued",
                CodespaceState.Provisioning => "Provisioning",
                CodespaceState.Available => "Available",
                CodespaceState.Awaiting => "Awaiting",
                CodespaceState.Unavailable => "Unavailable",
                CodespaceState.Deleted => "Deleted",
                CodespaceState.Moved => "Moved",
                CodespaceState.Shutdown => "Shutdown",
                CodespaceState.Archived => "Archived",
                CodespaceState.Starting => "Starting",
                CodespaceState.ShuttingDown => "ShuttingDown",
                CodespaceState.Failed => "Failed",
                CodespaceState.Exporting => "Exporting",
                CodespaceState.Updating => "Updating",
                CodespaceState.Rebuilding => "Rebuilding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespaceState ToEnum(string value)
        {
            return value switch
            {
                "Unknown" => CodespaceState.Unknown,
                "Created" => CodespaceState.Created,
                "Queued" => CodespaceState.Queued,
                "Provisioning" => CodespaceState.Provisioning,
                "Available" => CodespaceState.Available,
                "Awaiting" => CodespaceState.Awaiting,
                "Unavailable" => CodespaceState.Unavailable,
                "Deleted" => CodespaceState.Deleted,
                "Moved" => CodespaceState.Moved,
                "Shutdown" => CodespaceState.Shutdown,
                "Archived" => CodespaceState.Archived,
                "Starting" => CodespaceState.Starting,
                "ShuttingDown" => CodespaceState.ShuttingDown,
                "Failed" => CodespaceState.Failed,
                "Exporting" => CodespaceState.Exporting,
                "Updating" => CodespaceState.Updating,
                "Rebuilding" => CodespaceState.Rebuilding,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}