//HintName: G.IObjectsClient.ObjectsClassDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IObjectsClient
    {
        /// <summary>
        /// Delete an object.<br/>
        /// Delete an object based on its collection and UUID. &lt;br/&gt;&lt;br/&gt;Note: For backward compatibility, beacons also support an older, deprecated format without the collection name. As a result, when deleting a reference, the beacon specified has to match the beacon to be deleted exactly. In other words, if a beacon is present using the old format (without collection name) you also need to specify it the same way. &lt;br/&gt;&lt;br/&gt;In the beacon format, you need to always use `localhost` as the host, rather than the actual hostname. `localhost` here refers to the fact that the beacon's target is on the same Weaviate instance, as opposed to a foreign instance.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="id"></param>
        /// <param name="consistencyLevel">
        /// Default Value: QUORUM
        /// </param>
        /// <param name="tenant"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ErrorResponse> ObjectsClassDeleteAsync(
            string className,
            global::System.Guid id,
            global::G.ObjectsClassDeleteConsistencyLevel? consistencyLevel = global::G.ObjectsClassDeleteConsistencyLevel.QUORUM,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}