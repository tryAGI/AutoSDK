//HintName: G.Models.PersonalAccessTokenRequestRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of repository selection requested.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PersonalAccessTokenRequestRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subset")]
        Subset,
    }
}