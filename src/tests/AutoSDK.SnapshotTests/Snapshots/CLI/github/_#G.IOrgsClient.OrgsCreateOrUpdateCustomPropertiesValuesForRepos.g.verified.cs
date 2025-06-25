//HintName: G.IOrgsClient.OrgsCreateOrUpdateCustomPropertiesValuesForRepos.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create or update custom property values for organization repositories<br/>
        /// Create new or update existing custom property values for repositories in a batch that belong to an organization.<br/>
        /// Each target repository will have its custom property values updated to match the values provided in the request.<br/>
        /// A maximum of 30 repositories can be updated in a single request.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_values_editor` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
            string org,
            global::G.OrgsCreateOrUpdateCustomPropertiesValuesForReposRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update custom property values for organization repositories<br/>
        /// Create new or update existing custom property values for repositories in a batch that belong to an organization.<br/>
        /// Each target repository will have its custom property values updated to match the values provided in the request.<br/>
        /// A maximum of 30 repositories can be updated in a single request.<br/>
        /// Using a value of `null` for a custom property will remove or 'unset' the property value from the repository.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_values_editor` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryNames">
        /// The names of repositories that the custom property values will be applied to.
        /// </param>
        /// <param name="properties">
        /// List of custom property names and associated values to apply to the repositories.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsCreateOrUpdateCustomPropertiesValuesForReposAsync(
            string org,
            global::System.Collections.Generic.IList<string> repositoryNames,
            global::System.Collections.Generic.IList<global::G.CustomPropertyValue> properties,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}