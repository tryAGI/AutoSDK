//HintName: G.IPrompts2Client.SubsetTasks.g.cs
#nullable enable

namespace G
{
    public partial interface IPrompts2Client
    {
        /// <summary>
        /// ✨ Get Project Subset Task List with Predictions and Accuracy details<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        ///         Provides list of tasks, based on project subset. Includes predictions for tasks. For the 'HasGT' subset, accuracy metrics will also be provided.<br/>
        ///         
        /// </summary>
        /// <param name="includeTotal"></param>
        /// <param name="modelRun"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentModel"></param>
        /// <param name="projectPk"></param>
        /// <param name="projectSubset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedProjectSubsetTasksResponseList> SubsetTasksAsync(
            int projectPk,
            bool? includeTotal = default,
            int? modelRun = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            int? parentModel = default,
            string? projectSubset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}