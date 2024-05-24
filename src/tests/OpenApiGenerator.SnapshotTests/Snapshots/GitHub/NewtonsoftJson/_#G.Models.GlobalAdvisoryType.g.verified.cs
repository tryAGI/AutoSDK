//HintName: G.Models.GlobalAdvisoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of advisory.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalAdvisoryType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reviewed")]
        Reviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unreviewed")]
        Unreviewed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="malware")]
        Malware,
    }
}