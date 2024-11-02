//HintName: G.IStyleClient.DeleteStyle.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Delete Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteStyleAsync(
            global::System.Guid styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}