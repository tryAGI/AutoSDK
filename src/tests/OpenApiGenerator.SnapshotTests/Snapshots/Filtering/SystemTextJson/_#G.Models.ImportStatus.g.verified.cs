//HintName: G.Models.ImportStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class ImportStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Auth = "auth";
        /// <summary>
        /// 
        /// </summary>
        public const string Error = "error";
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string Detecting = "detecting";
        /// <summary>
        /// 
        /// </summary>
        public const string Choose = "choose";
        /// <summary>
        /// 
        /// </summary>
        public const string AuthFailed = "auth_failed";
        /// <summary>
        /// 
        /// </summary>
        public const string Importing = "importing";
        /// <summary>
        /// 
        /// </summary>
        public const string Mapping = "mapping";
        /// <summary>
        /// 
        /// </summary>
        public const string WaitingToPush = "waiting_to_push";
        /// <summary>
        /// 
        /// </summary>
        public const string Pushing = "pushing";
        /// <summary>
        /// 
        /// </summary>
        public const string Complete = "complete";
        /// <summary>
        /// 
        /// </summary>
        public const string Setup = "setup";
        /// <summary>
        /// 
        /// </summary>
        public const string Unknown = "unknown";
        /// <summary>
        /// 
        /// </summary>
        public const string DetectionFoundMultiple = "detection_found_multiple";
        /// <summary>
        /// 
        /// </summary>
        public const string DetectionFoundNothing = "detection_found_nothing";
        /// <summary>
        /// 
        /// </summary>
        public const string DetectionNeedsAuth = "detection_needs_auth";
    }
}