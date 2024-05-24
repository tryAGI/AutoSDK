//HintName: G.Models.PendingDeploymentReviewersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of reviewer.
    /// <br/>Example: User
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PendingDeploymentReviewersType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Team")]
        Team,
    }
}