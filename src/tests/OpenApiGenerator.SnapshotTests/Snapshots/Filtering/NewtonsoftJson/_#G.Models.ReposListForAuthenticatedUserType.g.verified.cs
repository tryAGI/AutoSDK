//HintName: G.Models.ReposListForAuthenticatedUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReposListForAuthenticatedUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
    }
}