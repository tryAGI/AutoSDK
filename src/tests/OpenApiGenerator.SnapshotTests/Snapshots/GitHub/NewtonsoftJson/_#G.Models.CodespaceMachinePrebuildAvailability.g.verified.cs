//HintName: G.Models.CodespaceMachinePrebuildAvailability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.
    /// <br/>Example: ready
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespaceMachinePrebuildAvailability
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
    }
}