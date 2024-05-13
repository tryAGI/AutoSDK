//HintName: G.Models.VectorStoreFileBatchObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileBatchObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }
}