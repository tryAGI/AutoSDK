//HintName: G.ITaskManagementClient.GetTasksById.g.cs
#nullable enable

namespace G
{
    public partial interface ITaskManagementClient
    {
        /// <summary>
        /// Get task detail<br/>
        /// Return details about a task. Consumers of this API should not expect updates more frequent than once every five seconds for a given task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// // npm install --save @runwayml/sdk<br/>
        /// import RunwayML from '@runwayml/sdk';<br/>
        /// // The env var RUNWAYML_API_SECRET is expected to contain your API key.<br/>
        /// const client = new RunwayML();<br/>
        /// // Fetch the current state of the task:<br/>
        /// const task = await client.tasks.retrieve(<br/>
        ///   '17f20503-6c24-4c16-946b-35dbbce2af2f'<br/>
        /// );<br/>
        /// // Or, wait for the task to succeed or fail:<br/>
        /// const task = await client.tasks<br/>
        ///   .retrieve('17f20503-6c24-4c16-946b-35dbbce2af2f')<br/>
        ///   .waitForTaskOutput();
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.GetTasksResponse> GetTasksByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}