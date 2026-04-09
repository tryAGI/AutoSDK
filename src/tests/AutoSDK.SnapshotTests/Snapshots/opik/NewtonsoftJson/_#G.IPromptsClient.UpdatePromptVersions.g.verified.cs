//HintName: G.IPromptsClient.UpdatePromptVersions.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Update prompt versions<br/>
        /// Update one or more prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties, such as tags etc., can be updated.<br/>
        /// Core properties like template and metadata cannot be modified after creation.<br/>
        /// PATCH semantics:<br/>
        /// - non-empty values update the field<br/>
        /// - null values preserve existing field values (no change)<br/>
        /// - empty values explicitly clear the field
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdatePromptVersionsAsync(

            global::G.PromptVersionBatchUpdate request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update prompt versions<br/>
        /// Update one or more prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties, such as tags etc., can be updated.<br/>
        /// Core properties like template and metadata cannot be modified after creation.<br/>
        /// PATCH semantics:<br/>
        /// - non-empty values update the field<br/>
        /// - null values preserve existing field values (no change)<br/>
        /// - empty values explicitly clear the field
        /// </summary>
        /// <param name="ids">
        /// IDs of prompt versions to update
        /// </param>
        /// <param name="update">
        /// Update to apply to prompt versions.<br/>
        /// Note: Prompt versions are immutable by design.<br/>
        /// Only organizational properties (such as tags etc.) can be updated.<br/>
        /// Core properties like template, metadata etc. cannot be modified after creation.
        /// </param>
        /// <param name="mergeTags">
        /// Tag merge behavior:<br/>
        /// - true: Add new tags to existing tags (union)<br/>
        /// - false: Replace all existing tags with new tags (default behaviour if not provided)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdatePromptVersionsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.PromptVersionUpdate update,
            bool? mergeTags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}