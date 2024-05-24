//HintName: G.Models.RepositoryAdvisoryCreditState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the user's acceptance of the credit.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryAdvisoryCreditState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="accepted")]
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="declined")]
        Declined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }
}