//HintName: G.IGistsClient.GistsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Update a gist<br/>
        /// Allows you to update a gist's description and to update, delete, or rename gist files. Files<br/>
        /// from the previous version of the gist that aren't explicitly changed during an edit<br/>
        /// are unchanged.<br/>
        /// At least one of `description` or `files` is required.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GistSimple> GistsUpdateAsync(
            string gistId,
            global::G.GistsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a gist<br/>
        /// Allows you to update a gist's description and to update, delete, or rename gist files. Files<br/>
        /// from the previous version of the gist that aren't explicitly changed during an edit<br/>
        /// are unchanged.<br/>
        /// At least one of `description` or `files` is required.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.base64+json`**: Returns the base64-encoded contents. This can be useful if your gist contains any invalid UTF-8 sequences.
        /// </summary>
        /// <param name="gistId"></param>
        /// <param name="description">
        /// The description of the gist.<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="files">
        /// The gist files to be updated, renamed, or deleted. Each `key` must match the current filename<br/>
        /// (including extension) of the targeted gist file. For example: `hello.py`.<br/>
        /// To delete a file, set the whole file to null. For example: `hello.py : null`. The file will also be<br/>
        /// deleted if the specified object does not contain at least one of `content` or `filename`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GistSimple> GistsUpdateAsync(
            string gistId,
            string? description = default,
            global::G.GistsUpdateRequestFiles? files = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}