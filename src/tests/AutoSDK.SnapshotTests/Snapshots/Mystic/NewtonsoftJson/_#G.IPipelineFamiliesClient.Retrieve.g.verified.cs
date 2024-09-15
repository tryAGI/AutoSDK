//HintName: G.IPipelineFamiliesClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFamiliesClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a pipeline family by name with its latest pipeline.<br/>
        /// If the user/selected team owns the family, the latest pipeline may be a<br/>
        /// private pipeline, otherwise it will only be public.
        /// </summary>
        /// <param name="pipelineFamilyName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineFamilyGet> RetrieveAsync(
            string pipelineFamilyName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}