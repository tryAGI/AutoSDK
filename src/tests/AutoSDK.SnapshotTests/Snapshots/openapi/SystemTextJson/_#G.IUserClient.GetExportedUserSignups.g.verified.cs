//HintName: G.IUserClient.GetExportedUserSignups.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="goWin"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserForExportedSignupFileResponseDto> GetExportedUserSignupsAsync(
            bool? goWin = default,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}