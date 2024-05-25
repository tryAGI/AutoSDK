//HintName: G.Models.PullsListSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PullsListSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="popularity")]
        Popularity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long-running")]
        LongRunning,
    }
}