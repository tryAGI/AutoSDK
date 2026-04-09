//HintName: G.IToolsClient.CreateTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create a new tool<br/>
        /// Create a new tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> CreateToolAsync(

            global::G.Tool request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new tool<br/>
        /// Create a new tool
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the tool<br/>
        /// Example: cfd531e0-82fc-11e9-bc42-526af7764f64
        /// </param>
        /// <param name="name">
        /// Name of the tool<br/>
        /// Example: date_time_tool
        /// </param>
        /// <param name="description">
        /// Description of the tool<br/>
        /// Example: A tool used for date and time operations
        /// </param>
        /// <param name="color">
        /// Color associated with the tool<br/>
        /// Example: #FF5733
        /// </param>
        /// <param name="iconSrc">
        /// Source URL for the tool's icon<br/>
        /// Example: https://example.com/icons/date.png
        /// </param>
        /// <param name="schema">
        /// JSON schema associated with the tool
        /// </param>
        /// <param name="func">
        /// Functionality description or code associated with the tool
        /// </param>
        /// <param name="createdDate">
        /// Date and time when the tool was created<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="updatedDate">
        /// Date and time when the tool was last updated<br/>
        /// Example: 2024-08-24T14:15:22Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> CreateToolAsync(
            global::System.Guid? id = default,
            string? name = default,
            string? description = default,
            string? color = default,
            string? iconSrc = default,
            string? schema = default,
            string? func = default,
            global::System.DateTime? createdDate = default,
            global::System.DateTime? updatedDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}