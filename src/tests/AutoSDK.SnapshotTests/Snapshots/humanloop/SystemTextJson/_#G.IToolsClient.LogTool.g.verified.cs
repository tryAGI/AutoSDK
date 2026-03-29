//HintName: G.IToolsClient.LogTool.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Log Tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogToolAsync(

            global::G.LogToolRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Log Tool
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environment"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="inputs"></param>
        /// <param name="source"></param>
        /// <param name="metadata"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="traceParentId"></param>
        /// <param name="save"></param>
        /// <param name="logId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateLogResponse> LogToolAsync(
            string? versionId = default,
            string? environment = default,
            string? path = default,
            string? id = default,
            string? output = default,
            object? inputs = default,
            string? source = default,
            object? metadata = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            string? error = default,
            string? traceParentId = default,
            bool? save = default,
            string? logId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}