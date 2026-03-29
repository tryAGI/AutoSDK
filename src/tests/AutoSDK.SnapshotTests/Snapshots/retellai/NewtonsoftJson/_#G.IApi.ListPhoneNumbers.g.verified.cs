//HintName: G.IApi.ListPhoneNumbers.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all phone numbers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PhoneNumberResponse>> ListPhoneNumbersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}