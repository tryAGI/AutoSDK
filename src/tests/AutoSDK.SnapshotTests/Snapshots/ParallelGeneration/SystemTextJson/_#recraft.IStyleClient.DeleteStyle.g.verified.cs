//HintName: recraft.IStyleClient.DeleteStyle.g.cs
#nullable enable

namespace recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// Delete Style
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteStyleAsync(
            global::System.Guid styleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}