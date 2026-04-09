//HintName: G.IAnnotationsClient.Update.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Update annotation<br/>
        /// Update existing attributes on an annotation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Annotation> UpdateAsync(
            int id,

            global::G.ApiAnnotationsPartialUpdateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update annotation<br/>
        /// Update existing attributes on an annotation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="completedBy">
        /// User ID of the person who created this annotation
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task (in seconds)<br/>
        /// Example: 100.5
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// Labeling result in JSON format. Read more about the format in [the Label Studio documentation.](https://labelstud.io/guide/task_format)<br/>
        /// Example: [{"from_name":"bboxes","image_rotation":0,"original_height":1080,"original_width":1920,"to_name":"image","type":"rectanglelabels","value":{"height":60,"rotation":0,"values":{"rectanglelabels":["Person"]},"width":50,"x":20,"y":30}}]
        /// </param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Annotation> UpdateAsync(
            int id,
            int? completedBy = default,
            bool? groundTruth = default,
            double? leadTime = default,
            int? project = default,
            global::System.Collections.Generic.IList<object>? result = default,
            int? task = default,
            int? updatedBy = default,
            bool? wasCancelled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}