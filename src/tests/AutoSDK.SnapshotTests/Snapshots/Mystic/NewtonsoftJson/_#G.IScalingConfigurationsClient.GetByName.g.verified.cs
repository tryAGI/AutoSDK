//HintName: G.IScalingConfigurationsClient.GetByName.g.cs
#nullable enable

namespace G
{
    public partial interface IScalingConfigurationsClient
    {
        /// <summary>
        /// Get By Name<br/>
        /// Retrieve a scaling configuration
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScalingConfigGet> GetByNameAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}