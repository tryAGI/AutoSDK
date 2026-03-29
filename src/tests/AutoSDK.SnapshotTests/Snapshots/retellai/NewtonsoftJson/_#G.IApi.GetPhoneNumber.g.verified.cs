//HintName: G.IApi.GetPhoneNumber.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve details of a specific phone number
        /// </summary>
        /// <param name="phoneNumber">
        /// Example: +14157774444
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberResponse> GetPhoneNumberAsync(
            string phoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}