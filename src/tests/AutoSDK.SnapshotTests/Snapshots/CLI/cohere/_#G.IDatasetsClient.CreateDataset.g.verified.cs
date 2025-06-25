//HintName: G.IDatasetsClient.CreateDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::G.DatasetType type,
            global::G.CreateDatasetRequest request,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Dataset<br/>
        /// Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of the dataset
        /// </param>
        /// <param name="keepOriginalFile"></param>
        /// <param name="skipMalformedInput"></param>
        /// <param name="keepFields"></param>
        /// <param name="optionalFields"></param>
        /// <param name="textSeparator"></param>
        /// <param name="csvDelimiter"></param>
        /// <param name="xClientName"></param>
        /// <param name="data">
        /// The file to upload
        /// </param>
        /// <param name="dataname">
        /// The file to upload
        /// </param>
        /// <param name="evalData">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="evalDataname">
        /// An optional evaluation file to upload
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetResponse> CreateDatasetAsync(
            string name,
            global::G.DatasetType type,
            byte[] data,
            string dataname,
            bool? keepOriginalFile = default,
            bool? skipMalformedInput = default,
            global::System.Collections.Generic.IList<string>? keepFields = default,
            global::System.Collections.Generic.IList<string>? optionalFields = default,
            string? textSeparator = default,
            string? csvDelimiter = default,
            string? xClientName = default,
            byte[]? evalData = default,
            string? evalDataname = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}