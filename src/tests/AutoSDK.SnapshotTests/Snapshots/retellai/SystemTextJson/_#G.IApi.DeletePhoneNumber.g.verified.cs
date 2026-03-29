//HintName: G.IApi.DeletePhoneNumber.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete an existing phone number
        /// </summary>
        /// <param name="phoneNumber">
        /// Example: +14157774444
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePhoneNumberAsync(
            string phoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}