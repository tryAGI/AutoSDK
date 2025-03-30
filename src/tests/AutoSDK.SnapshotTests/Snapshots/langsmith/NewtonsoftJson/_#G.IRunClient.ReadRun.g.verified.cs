//HintName: G.IRunClient.ReadRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Read Run<br/>
        /// Get a specific run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="excludeSerialized">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RunSchema> ReadRunAsync(
            global::System.Guid runId,
            global::System.Guid? sessionId = default,
            global::System.DateTime? startTime = default,
            bool? excludeS3StoredAttributes = default,
            bool? excludeSerialized = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}