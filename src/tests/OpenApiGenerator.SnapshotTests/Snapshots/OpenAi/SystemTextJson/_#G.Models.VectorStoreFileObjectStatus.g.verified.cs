//HintName: G.Models.VectorStoreFileObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
    /// </summary>
    public abstract class VectorStoreFileObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
        /// <summary>
        /// 
        /// </summary>
        public const string Cancelled = "cancelled";
        /// <summary>
        /// 
        /// </summary>
        public const string Failed = "failed";
    }
}