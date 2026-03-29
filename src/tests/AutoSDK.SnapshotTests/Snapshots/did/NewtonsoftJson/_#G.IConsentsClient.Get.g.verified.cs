//HintName: G.IConsentsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IConsentsClient
    {
        /// <summary>
        /// Get a consent by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetResponse7> GetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}