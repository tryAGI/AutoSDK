//HintName: G.Models.ActionsGetActionsCacheListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: last_accessed_at
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsGetActionsCacheListSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created_at")]
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="last_accessed_at")]
        LastAccessedAt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="size_in_bytes")]
        SizeInBytes,
    }
}