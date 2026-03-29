//HintName: G.IPhoneNumbersClient.PhoneNumberControllerUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberControllerUpdateResponse> PhoneNumberControllerUpdateAsync(
            string id,

            global::G.PhoneNumberControllerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PhoneNumberControllerUpdateResponse> PhoneNumberControllerUpdateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}