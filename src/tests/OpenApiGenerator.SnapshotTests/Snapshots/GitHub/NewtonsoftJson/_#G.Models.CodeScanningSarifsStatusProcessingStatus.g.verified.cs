//HintName: G.Models.CodeScanningSarifsStatusProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningSarifsStatusProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="complete")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }
}