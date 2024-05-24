//HintName: G.Models.OrganizationSecretScanningAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationSecretScanningAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="resolved")]
        Resolved,
    }
}