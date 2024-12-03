//HintName: G.Models.WorkflowState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: active
    /// </summary>
    public enum WorkflowState
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        DisabledFork,
        /// <summary>
        /// 
        /// </summary>
        DisabledInactivity,
        /// <summary>
        /// 
        /// </summary>
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