//HintName: G.IBlocksClient.DeleteBlock.g.cs
#nullable enable

namespace G
{
    public partial interface IBlocksClient
    {
        /// <summary>
        /// Delete Block
        /// </summary>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteBlockAsync(
            string blockId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}