//HintName: G.Models.ReviewCustomGatesStateRequiredState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to approve or reject deployment to the specified environments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReviewCustomGatesStateRequiredState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approved")]
        Approved,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
    }
}