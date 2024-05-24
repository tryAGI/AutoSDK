//HintName: G.Models.CodeScanningDefaultSetupUpdateState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The desired state of code scanning default setup.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupUpdateState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="configured")]
        Configured,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not-configured")]
        NotConfigured,
    }
}