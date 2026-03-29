//HintName: G.ISpansClient.DeleteSpan.g.cs
#nullable enable

namespace G
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Delete a span by span_identifier<br/>
        /// Delete a single span by identifier.<br/>
        ///         **Important**: This operation deletes ONLY the specified span itself and does NOT<br/>
        ///         delete its descendants/children. All child spans will remain in the trace and<br/>
        ///         become orphaned (their parent_id will point to a non-existent span).<br/>
        ///         Behavior:<br/>
        ///         - Deletes only the target span (preserves all descendant spans)<br/>
        ///         - If this was the last span in the trace, the trace record is also deleted<br/>
        ///         - If the deleted span had a parent, its cumulative metrics (error count, token counts)<br/>
        ///           are subtracted from all ancestor spans in the chain<br/>
        ///         **Note**: This operation is irreversible and may create orphaned spans.
        /// </summary>
        /// <param name="spanIdentifier">
        /// The span identifier: either a relay GlobalID or OpenTelemetry span_id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanAsync(
            string spanIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}