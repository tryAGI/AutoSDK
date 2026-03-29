//HintName: G.IApi.DeviceStatsDeviceStatsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Device Stats
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeviceStatsDeviceStatsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}