//HintName: G.ISquadsClient.SquadControllerFindOne.g.cs
#nullable enable

namespace G
{
    public partial interface ISquadsClient
    {
        /// <summary>
        /// Get Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Squad> SquadControllerFindOneAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}