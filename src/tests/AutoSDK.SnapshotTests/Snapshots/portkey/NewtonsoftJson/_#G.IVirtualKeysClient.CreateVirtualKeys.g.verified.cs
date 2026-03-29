//HintName: G.IVirtualKeysClient.CreateVirtualKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Create a Virtual Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVirtualKeysResponse> CreateVirtualKeysAsync(

            global::G.CreateVirtualKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Virtual Key
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="key"></param>
        /// <param name="note"></param>
        /// <param name="apiVersion"></param>
        /// <param name="resourceName"></param>
        /// <param name="deploymentName"></param>
        /// <param name="workspaceId">
        /// optional, needed when using organisation admin API keys
        /// </param>
        /// <param name="deploymentConfig"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="rateLimits"></param>
        /// <param name="expiresAt"></param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique. When "key" is mapped, the key field becomes optional.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateVirtualKeysResponse> CreateVirtualKeysAsync(
            string? name = default,
            global::G.CreateVirtualKeysRequestProvider? provider = default,
            string? key = default,
            string? note = default,
            string? apiVersion = default,
            string? resourceName = default,
            string? deploymentName = default,
            global::System.Guid? workspaceId = default,
            global::System.Collections.Generic.IList<global::G.CreateVirtualKeysRequestDeploymentConfigItem>? deploymentConfig = default,
            global::G.UsageLimits? usageLimits = default,
            global::G.RateLimits? rateLimits = default,
            global::System.DateTime? expiresAt = default,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}