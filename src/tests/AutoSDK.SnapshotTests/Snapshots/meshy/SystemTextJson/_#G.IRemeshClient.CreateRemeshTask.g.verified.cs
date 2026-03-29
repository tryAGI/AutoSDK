//HintName: G.IRemeshClient.CreateRemeshTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRemeshClient
    {
        /// <summary>
        /// Create a Remesh task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRemeshTaskAsync(

            global::G.RemeshRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Remesh task
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task to remesh
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </param>
        /// <param name="targetFormats">
        /// Default Value: [glb]
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="resizeHeight">
        /// Resize to height in meters (0 = no resize)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        /// <param name="convertFormatOnly">
        /// Only convert format, skip remesh processing
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRemeshTaskAsync(
            string? inputTaskId = default,
            string? modelUrl = default,
            global::System.Collections.Generic.IList<global::G.TargetFormatRemesh>? targetFormats = default,
            global::G.Topology? topology = default,
            int? targetPolycount = default,
            double? resizeHeight = default,
            bool? autoSize = default,
            global::G.OriginAt? originAt = default,
            bool? convertFormatOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}