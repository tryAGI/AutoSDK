//HintName: G.Models.WorkflowState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: active
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkflowState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deleted")]
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled_fork")]
        DisabledFork,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled_inactivity")]
        DisabledInactivity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled_manually")]
        DisabledManually,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowState value)
        {
            return value switch
            {
                WorkflowState.Active => "active",
                WorkflowState.Deleted => "deleted",
                WorkflowState.DisabledFork => "disabled_fork",
                WorkflowState.DisabledInactivity => "disabled_inactivity",
                WorkflowState.DisabledManually => "disabled_manually",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowState? ToEnum(string value)
        {
            return value switch
            {
                "active" => WorkflowState.Active,
                "deleted" => WorkflowState.Deleted,
                "disabled_fork" => WorkflowState.DisabledFork,
                "disabled_inactivity" => WorkflowState.DisabledInactivity,
                "disabled_manually" => WorkflowState.DisabledManually,
                _ => null,
            };
        }
    }
}