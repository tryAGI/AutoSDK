//HintName: G.IKgApiClient.Question.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Question<br/>
        /// Ask a question to specified Knowledge Graphs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/graphs/question \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"graph_ids":["182bd5e5-6e1a-4fe4-a799-aa6d9a6ab26e"],"question":"What is the generic name for the drug Bavencio?"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.QuestionResponse> QuestionAsync(

            global::G.QuestionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Question<br/>
        /// Ask a question to specified Knowledge Graphs.
        /// </summary>
        /// <param name="graphIds">
        /// The unique identifiers of the Knowledge Graphs to query.
        /// </param>
        /// <param name="subqueries">
        /// Specify whether to include subqueries.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="question">
        /// The question to answer using the Knowledge Graph.
        /// </param>
        /// <param name="queryConfig">
        /// Configuration options for Knowledge Graph queries.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.QuestionResponse> QuestionAsync(
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            string question,
            bool? subqueries = default,
            global::G.GraphQueryConfig? queryConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}