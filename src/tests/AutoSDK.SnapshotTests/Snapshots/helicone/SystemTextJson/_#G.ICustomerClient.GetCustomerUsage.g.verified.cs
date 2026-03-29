//HintName: G.ICustomerClient.GetCustomerUsage.g.cs
#nullable enable

namespace G
{
    public partial interface ICustomerClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomerUsage> GetCustomerUsageAsync(
            string customerId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CustomerUsage> GetCustomerUsageAsync(
            string customerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}