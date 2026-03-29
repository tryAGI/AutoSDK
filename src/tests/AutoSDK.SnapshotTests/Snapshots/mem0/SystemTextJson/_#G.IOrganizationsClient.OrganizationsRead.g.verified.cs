//HintName: G.IOrganizationsClient.OrganizationsRead.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationsReadResponseItem>> OrganizationsReadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}