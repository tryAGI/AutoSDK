//HintName: G.Models.CodespaceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.<br/>
    /// Example: Available
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceState
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