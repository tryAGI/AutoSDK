//HintName: G.ICodesOfConductClient.CodesOfConductGetConductCode.g.cs
#nullable enable

namespace G
{
    public partial interface ICodesOfConductClient
    {
        /// <summary>
        /// Get a code of conduct<br/>
        /// Returns information about the specified GitHub code of conduct.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CodeOfConduct> CodesOfConductGetConductCodeAsync(
            string key,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}