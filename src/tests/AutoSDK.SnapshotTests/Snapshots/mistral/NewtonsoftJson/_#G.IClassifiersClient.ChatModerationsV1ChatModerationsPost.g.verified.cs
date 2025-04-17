//HintName: G.IClassifiersClient.ChatModerationsV1ChatModerationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassifiersClient
    {
        /// <summary>
        /// Chat Moderations
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModerationResponse> ChatModerationsV1ChatModerationsPostAsync(
            global::G.ChatModerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Chat Moderations
        /// </summary>
        /// <param name="input">
        /// Chat to classify
        /// </param>
        /// <param name="model"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModerationResponse> ChatModerationsV1ChatModerationsPostAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.InputVariant1Item>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.InputVariant2ItemItem>>> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}