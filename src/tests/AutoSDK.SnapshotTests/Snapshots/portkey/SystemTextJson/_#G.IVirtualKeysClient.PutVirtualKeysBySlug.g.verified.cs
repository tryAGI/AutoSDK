//HintName: G.IVirtualKeysClient.PutVirtualKeysBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IVirtualKeysClient
    {
        /// <summary>
        /// Update a Virtual Key
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutVirtualKeysBySlugAsync(
            string slug,

            global::G.PutVirtualKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Virtual Key
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="name"></param>
        /// <param name="key"></param>
        /// <param name="note"></param>
        /// <param name="deploymentConfig"></param>
        /// <param name="usageLimits">
        /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
        /// </param>
        /// <param name="secretMappings">
        /// Dynamically resolve secrets from secret references at runtime. Valid target_field values are "key" or "model_config.&lt;field&gt;" (e.g. "model_config.awsSecretAccessKey"). Each target_field must be unique.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutVirtualKeysBySlugAsync(
            string slug,
            string? name = default,
            string? key = default,
            string? note = default,
            global::System.Collections.Generic.IList<global::G.PutVirtualKeysRequestDeploymentConfigItem>? deploymentConfig = default,
            global::G.UsageLimits? usageLimits = default,
            global::System.Collections.Generic.IList<global::G.SecretMapping>? secretMappings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}