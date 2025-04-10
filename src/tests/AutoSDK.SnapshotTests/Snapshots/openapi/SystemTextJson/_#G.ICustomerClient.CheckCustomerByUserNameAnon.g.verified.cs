//HintName: G.ICustomerClient.CheckCustomerByUserNameAnon.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomerClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="searchMode"></param>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomerForDetailResponseDto> CheckCustomerByUserNameAnonAsync(
            string? userName = default,
            global::G.UserNameSearchModeEnum? searchMode = default,
            long? id = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}