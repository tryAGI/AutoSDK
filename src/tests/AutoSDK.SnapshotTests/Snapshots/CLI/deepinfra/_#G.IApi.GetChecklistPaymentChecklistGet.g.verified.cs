//HintName: G.IApi.GetChecklistPaymentChecklistGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Checklist
        /// </summary>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Checklist> GetChecklistPaymentChecklistGetAsync(
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}