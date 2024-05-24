//HintName: G.Models.OrganizationSecretScanningAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    public abstract class OrganizationSecretScanningAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Open = "open";
        /// <summary>
        /// 
        /// </summary>
        public const string Resolved = "resolved";
    }
}