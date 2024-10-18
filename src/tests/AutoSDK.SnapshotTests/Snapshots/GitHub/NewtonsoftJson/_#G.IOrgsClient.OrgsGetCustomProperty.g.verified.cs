//HintName: G.IOrgsClient.OrgsGetCustomProperty.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get a custom property for an organization<br/>
        /// Gets a custom property that is defined for an organization.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomProperty> OrgsGetCustomPropertyAsync(
            string org,
            string customPropertyName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}