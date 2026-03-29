//HintName: G.IStyleRulesClient.GetCustomInstruction.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Retrieve a custom instruction
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="instructionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomInstruction> GetCustomInstructionAsync(
            string styleId,
            string instructionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}