//HintName: G.ILicensesClient.LicensesGetAllCommonlyUsed.g.cs
#nullable enable

namespace G
{
    public partial interface ILicensesClient
    {
        /// <summary>
        /// Get all commonly used licenses<br/>
        /// Lists the most commonly used licenses on GitHub. For more information, see "[Licensing a repository ](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository)."
        /// </summary>
        /// <param name="featured"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LicenseSimple>> LicensesGetAllCommonlyUsedAsync(
            bool? featured = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}