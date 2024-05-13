//HintName: G.Models.VectorStoreObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use.
    /// </summary>
    public abstract class VectorStoreObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Expired = "expired";
        /// <summary>
        /// 
        /// </summary>
        public const string InProgress = "in_progress";
        /// <summary>
        /// 
        /// </summary>
        public const string Completed = "completed";
    }
}