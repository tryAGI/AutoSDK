//HintName: G.ICreateVideoAPIClient.V2VideoGenerate.g.cs
#nullable enable

namespace G
{
    public partial interface ICreateVideoAPIClient
    {
        /// <summary>
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            global::G.V2VideoGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// v2/video/generate<br/>
        /// Generated Video: [https://app.heygen.com/share/67cd13935445457eaa99040070bdb545](https://app.heygen.com/share/67cd13935445457eaa99040070bdb545)<br/>
        /// &lt;img src="https://resource.heygen.ai/video/gifs/67cd13935445457eaa99040070bdb545.gif" alt=""&gt;
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <param name="callbackId"></param>
        /// <param name="dimension"></param>
        /// <param name="test">
        /// Example: true
        /// </param>
        /// <param name="title">
        /// Example: My Title
        /// </param>
        /// <param name="videoInputs">
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task V2VideoGenerateAsync(
            object? aspectRatio = default,
            object? callbackId = default,
            global::G.V2VideoGenerateRequestDimension? dimension = default,
            bool? test = default,
            string? title = default,
            global::System.Collections.Generic.IList<global::G.V2VideoGenerateRequestVideoInput>? videoInputs = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}