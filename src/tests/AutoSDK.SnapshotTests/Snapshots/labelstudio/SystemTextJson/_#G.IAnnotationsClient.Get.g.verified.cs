//HintName: G.IAnnotationsClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Get annotation by its ID<br/>
        /// Retrieve a specific annotation for a task using the annotation result ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Annotation> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}