//HintName: G.Models.ReposListForksSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: newest
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForksSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="newest")]
        Newest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oldest")]
        Oldest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stargazers")]
        Stargazers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="watchers")]
        Watchers,
    }
}