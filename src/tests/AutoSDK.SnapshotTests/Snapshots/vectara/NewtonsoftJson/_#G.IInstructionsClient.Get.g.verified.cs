//HintName: G.IInstructionsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {
        /// <summary>
        /// Get instruction<br/>
        /// Retrieve the full definition of a specific instruction, including its template, metadata, enabled status, and version. Instruction templates may contain Velocity expressions that reference tools and metadata. If no version is specified, the latest version is returned.
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
        global::System.Threading.Tasks.Task<global::G.Instruction> GetAsync(
            string instructionId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            int? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}