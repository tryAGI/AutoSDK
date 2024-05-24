//HintName: G.Models.WorkflowState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: active
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
}