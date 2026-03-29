//HintName: G.IBlocksClient.DetachIdentityFromBlock.g.cs
#nullable enable

namespace G
{
    public partial interface IBlocksClient
    {
        /// <summary>
        /// Detach Identity From Block<br/>
        /// Detach an identity from a block.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="blockId">
        /// The ID of the block in the format 'block-&lt;uuid4&gt;'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BlockResponse> DetachIdentityFromBlockAsync(
            string identityId,
            string blockId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}