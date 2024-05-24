//HintName: G.Models.SecretScanningAlertValidity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The token status as of the latest validity check.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningAlertValidity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactive")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }
}