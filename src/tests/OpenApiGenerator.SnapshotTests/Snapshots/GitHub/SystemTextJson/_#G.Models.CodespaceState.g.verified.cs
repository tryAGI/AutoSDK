//HintName: G.Models.CodespaceState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this codespace.
    /// <br/>Example: Available
    /// </summary>
    public abstract class CodespaceState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Unknown = "Unknown";
        /// <summary>
        /// 
        /// </summary>
        public const string Created = "Created";
        /// <summary>
        /// 
        /// </summary>
        public const string Queued = "Queued";
        /// <summary>
        /// 
        /// </summary>
        public const string Provisioning = "Provisioning";
        /// <summary>
        /// 
        /// </summary>
        public const string Available = "Available";
        /// <summary>
        /// 
        /// </summary>
        public const string Awaiting = "Awaiting";
        /// <summary>
        /// 
        /// </summary>
        public const string Unavailable = "Unavailable";
        /// <summary>
        /// 
        /// </summary>
        public const string Deleted = "Deleted";
        /// <summary>
        /// 
        /// </summary>
        public const string Moved = "Moved";
        /// <summary>
        /// 
        /// </summary>
        public const string Shutdown = "Shutdown";
        /// <summary>
        /// 
        /// </summary>
        public const string Archived = "Archived";
        /// <summary>
        /// 
        /// </summary>
        public const string Starting = "Starting";
        /// <summary>
        /// 
        /// </summary>
        public const string ShuttingDown = "ShuttingDown";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "Failed";
        /// <summary>
        /// 
        /// </summary>
        public const string Exporting = "Exporting";
        /// <summary>
        /// 
        /// </summary>
        public const string Updating = "Updating";
        /// <summary>
        /// 
        /// </summary>
        public const string Rebuilding = "Rebuilding";
    }
}