//HintName: G.ICloudClient.AuthAws.g.cs
#nullable enable

namespace G
{
    public partial interface ICloudClient
    {
        /// <summary>
        /// Auth Aws
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AuthAwsAsync(
            global::G.AWSAuthCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Auth Aws
        /// </summary>
        /// <param name="roleArn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AuthAwsAsync(
            string roleArn,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}