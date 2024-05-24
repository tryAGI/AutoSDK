//HintName: G.Models.TeamFullPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of privacy this team should have
    /// <br/>Example: closed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamFullPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secret")]
        Secret,
    }
}