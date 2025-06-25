//HintName: G.IClassificationsClient.ClassificationsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IClassificationsClient
    {
        /// <summary>
        /// Starts a classification.<br/>
        /// Trigger a classification based on the specified params. Classifications will run in the background, use GET /classifications/&lt;id&gt; to retrieve the status of your classification.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Classification> ClassificationsPostAsync(
            global::G.Classification request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Starts a classification.<br/>
        /// Trigger a classification based on the specified params. Classifications will run in the background, use GET /classifications/&lt;id&gt; to retrieve the status of your classification.
        /// </summary>
        /// <param name="id">
        /// ID to uniquely identify this classification run<br/>
        /// Example: ee722219-b8ec-4db1-8f8d-5150bb1a9e0c
        /// </param>
        /// <param name="class">
        /// class (name) which is used in this classification<br/>
        /// Example: City
        /// </param>
        /// <param name="classifyProperties">
        /// which ref-property to set as part of the classification<br/>
        /// Example: [inCountry]
        /// </param>
        /// <param name="basedOnProperties">
        /// base the text-based classification on these fields (of type text)<br/>
        /// Example: [description]
        /// </param>
        /// <param name="status">
        /// status of this classification<br/>
        /// Example: running
        /// </param>
        /// <param name="meta">
        /// Additional information to a specific classification
        /// </param>
        /// <param name="type">
        /// which algorithm to use for classifications
        /// </param>
        /// <param name="settings">
        /// classification-type specific settings
        /// </param>
        /// <param name="error">
        /// error message if status == failed<br/>
        /// Example: classify xzy: something went wrong
        /// </param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Classification> ClassificationsPostAsync(
            global::System.Guid? id = default,
            string? @class = default,
            global::System.Collections.Generic.IList<string>? classifyProperties = default,
            global::System.Collections.Generic.IList<string>? basedOnProperties = default,
            global::G.ClassificationStatus? status = default,
            global::G.ClassificationMeta? meta = default,
            string? type = default,
            object? settings = default,
            string? error = default,
            global::G.ClassificationFilters? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}