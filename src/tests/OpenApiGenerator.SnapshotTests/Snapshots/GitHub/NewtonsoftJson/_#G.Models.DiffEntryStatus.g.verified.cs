//HintName: G.Models.DiffEntryStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: added
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiffEntryStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="added")]
        Added,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
        Removed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="modified")]
        Modified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="renamed")]
        Renamed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="copied")]
        Copied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="changed")]
        Changed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unchanged")]
        Unchanged,
    }
}