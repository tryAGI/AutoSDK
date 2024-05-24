//HintName: G.Models.CodespaceMachinePrebuildAvailability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be "null" if prebuilds are not supported or prebuild availability could not be determined. Value will be "none" if no prebuild is available. Latest values "ready" and "in_progress" indicate the prebuild availability status.
    /// <br/>Example: ready
    /// </summary>
    public abstract class CodespaceMachinePrebuildAvailability
    {
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string Ready = "ready";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
    }
}