//HintName: G.IVoicesClient.VoicesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a new cloned voice from an audio sample. The created voice will be private to your account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> VoicesCreateAsync(
            global::G.VoicesCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new cloned voice from an audio sample. The created voice will be private to your account.
        /// </summary>
        /// <param name="file">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="filename">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="name">
        /// Name for the cloned voice. Must be unique within your account.<br/>
        /// Example: My Custom Voice
        /// </param>
        /// <param name="description">
        /// Optional description for the voice. If not provided, a default description will be generated.<br/>
        /// Example: Voice recorded on Jan 1, 2024
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> VoicesCreateAsync(
            byte[] file,
            string filename,
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}