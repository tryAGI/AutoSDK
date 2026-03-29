//HintName: G.IPropertyClient.GetPropertiesOverTime.g.cs
#nullable enable

namespace G
{
    public partial interface IPropertyClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString> GetPropertiesOverTimeAsync(

            global::G.AllOf<global::G.DataOverTimeRequest, global::G.GetPropertiesOverTimeRequest2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPropertyStringTotalCostNumberRequestCountNumberCreatedAtTruncStringArrayString> GetPropertiesOverTimeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}