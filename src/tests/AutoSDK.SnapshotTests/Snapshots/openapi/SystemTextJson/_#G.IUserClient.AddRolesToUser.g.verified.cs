//HintName: G.IUserClient.AddRolesToUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserForUpdateResponseDto> AddRolesToUserAsync(
            global::G.UserForAddRolesRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="addressLine1"></param>
        /// <param name="city"></param>
        /// <param name="countryIsoCode"></param>
        /// <param name="xTera">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserForUpdateResponseDto> AddRolesToUserAsync(
            string? currentCulture = default,
            long? id = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? firstName = default,
            string? lastName = default,
            string? userName = default,
            string? email = default,
            string? phoneNumber = default,
            string? addressLine1 = default,
            string? city = default,
            string? countryIsoCode = default,
            bool? xTera = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}