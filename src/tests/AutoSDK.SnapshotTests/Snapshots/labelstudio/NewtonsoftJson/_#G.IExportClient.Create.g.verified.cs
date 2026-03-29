//HintName: G.IExportClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseExportCreate> CreateAsync(
            int id,

            global::G.LseExportCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new export snapshot<br/>
        /// Create a new export request to start a background task and generate an export file for a specific project by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="annotationFilterOptions"></param>
        /// <param name="convertedFormats"></param>
        /// <param name="counters"></param>
        /// <param name="createdBy">
        /// A ModelSerializer that takes additional arguments for<br/>
        /// "fields", "omit" and "expand" in order to<br/>
        /// control which fields are displayed, and whether to replace simple<br/>
        /// values with complex, nested serializations
        /// </param>
        /// <param name="finishedAt">
        /// Complete or fail time
        /// </param>
        /// <param name="md5"></param>
        /// <param name="serializationOptions"></param>
        /// <param name="status"></param>
        /// <param name="taskFilterOptions"></param>
        /// <param name="title"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseExportCreate> CreateAsync(
            int id,
            global::G.LseAnnotationFilterOptionsRequest? annotationFilterOptions = default,
            global::System.Collections.Generic.IList<global::G.ConvertedFormatRequest>? convertedFormats = default,
            object? counters = default,
            global::G.UserSimpleRequest? createdBy = default,
            global::System.DateTime? finishedAt = default,
            string? md5 = default,
            global::G.SerializationOptionsRequest? serializationOptions = default,
            global::G.Status7bfEnum? status = default,
            global::G.LseTaskFilterOptionsRequest? taskFilterOptions = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}