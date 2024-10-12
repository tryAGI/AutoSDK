//HintName: G.IOrgsClient.UpsertTtlSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Upsert Ttl Settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TTLSettings> UpsertTtlSettingsAsync(
            global::G.UpsertTTLSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert Ttl Settings
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="defaultTraceTier"></param>
        /// <param name="applyToAllProjects">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TTLSettings> UpsertTtlSettingsAsync(
            global::G.TraceTier3 defaultTraceTier,
            global::G.AnyOf<global::System.Guid?, object>? tenantId = default,
            bool? applyToAllProjects = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}