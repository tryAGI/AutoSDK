//HintName: G.IMemoriesClient.MemoriesEventsList.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoriesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task MemoriesEventsListAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}