//HintName: G.IPrompts2Client.List2.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ List prompts<br/>
        /// List all prompts.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ModelInterfaceSerializerGET>> List2Async(
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}