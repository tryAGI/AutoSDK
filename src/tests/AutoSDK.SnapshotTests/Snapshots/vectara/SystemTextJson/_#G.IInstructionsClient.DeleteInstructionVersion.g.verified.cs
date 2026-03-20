//HintName: G.IInstructionsClient.DeleteInstructionVersion.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {
        /// <summary>
        /// Delete instruction version<br/>
        /// Permanently delete the specified version of the instruction. This action cannot be undone.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="version">
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteInstructionVersionAsync(
            string instructionId,
            int version,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}