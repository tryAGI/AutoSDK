//HintName: G.IScalingConfigurationsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Create<br/>
        /// Create a scaling configuration for pipelines
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScalingConfigGet> CreateAsync(
            global::G.ScalingConfigCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create<br/>
        /// Create a scaling configuration for pipelines
        /// </summary>
        /// <param name="name"></param>
        /// <param name="minimumNodes">
        /// Default Value: 0
        /// </param>
        /// <param name="maximumNodes">
        /// Default Value: 100
        /// </param>
        /// <param name="type">
        /// An enumeration.
        /// </param>
        /// <param name="args"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScalingConfigGet> CreateAsync(
            string name,
            global::G.ScalingConfigCreateArgs args,
            int minimumNodes = 0,
            int maximumNodes = 100,
            global::G.ScalingConfigType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}