//HintName: G.ILabels2Client.Delete2.g.cs
#nullable enable

namespace G
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// Remove labels<br/>
        /// Remove labels from your project without updating the labeling configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}