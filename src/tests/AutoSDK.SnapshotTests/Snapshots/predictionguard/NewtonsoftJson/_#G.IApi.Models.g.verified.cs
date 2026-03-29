//HintName: G.IApi.Models.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Models<br/>
        /// Return available models for an endpoint and relevant metadata for them.
        /// </summary>
        /// <param name="capability">
        /// Optional path variable to allow for sorting by capability. Leave blank to see all models.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsResponse200> ModelsAsync(
            global::G.ModelsCapabilityGetParametersCapability? capability,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}