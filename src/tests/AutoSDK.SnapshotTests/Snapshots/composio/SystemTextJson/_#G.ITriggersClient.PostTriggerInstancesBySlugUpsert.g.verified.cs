//HintName: G.ITriggersClient.PostTriggerInstancesBySlugUpsert.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Create or update a trigger<br/>
        /// Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Requires a connected account ID to associate the trigger with a specific user connection.
        /// </summary>
        /// <param name="slug">
        /// The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostTriggerInstancesBySlugUpsertResponse> PostTriggerInstancesBySlugUpsertAsync(
            string slug,

            global::G.PostTriggerInstancesBySlugUpsertRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a trigger<br/>
        /// Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Requires a connected account ID to associate the trigger with a specific user connection.
        /// </summary>
        /// <param name="slug">
        /// The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="connectedAccountId">
        /// Connected account nanoid
        /// </param>
        /// <param name="triggerConfig2">
        /// Trigger configuration
        /// </param>
        /// <param name="toolkitVersions">
        /// Toolkit version specification. Supports "latest" string or a record mapping toolkit slugs to specific versions.<br/>
        /// Example: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostTriggerInstancesBySlugUpsertResponse> PostTriggerInstancesBySlugUpsertAsync(
            string slug,
            string? connectedAccountId = default,
            global::System.Collections.Generic.Dictionary<string, object?>? triggerConfig2 = default,
            global::G.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>? toolkitVersions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}