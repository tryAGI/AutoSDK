//HintName: G.IUserClient.DeleteUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="addressLine1"></param>
        /// <param name="addressLine2"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="countryIsoCode"></param>
        /// <param name="isDeleted"></param>
        /// <param name="passwordChangeRequired"></param>
        /// <param name="profileUpdateRequired"></param>
        /// <param name="securityWordsGenerated"></param>
        /// <param name="securityWordsResetRequired"></param>
        /// <param name="instagramHandle"></param>
        /// <param name="isDisabled"></param>
        /// <param name="blockRemarks"></param>
        /// <param name="firebaseNotificationToken"></param>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="emailConfirmed"></param>
        /// <param name="quickPay"></param>
        /// <param name="xTera"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUserAsync(
            long? id = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? firstName = default,
            string? lastName = default,
            string? userName = default,
            string? email = default,
            string? phoneNumber = default,
            string? addressLine1 = default,
            string? addressLine2 = default,
            string? city = default,
            string? region = default,
            string? countryIsoCode = default,
            bool? isDeleted = default,
            bool? passwordChangeRequired = default,
            bool? profileUpdateRequired = default,
            bool? securityWordsGenerated = default,
            bool? securityWordsResetRequired = default,
            string? instagramHandle = default,
            bool? isDisabled = default,
            string? blockRemarks = default,
            string? firebaseNotificationToken = default,
            double? longitude = default,
            double? latitude = default,
            global::System.DateTime? dateOfBirth = default,
            bool? emailConfirmed = default,
            bool? quickPay = default,
            bool? xTera = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}