//HintName: G.IV4AvatarsClient.GetAvatarById.g.cs
#nullable enable

namespace G
{
    public partial interface IV4AvatarsClient
    {
        /// <summary>
        /// Get avatar by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.AllOf<global::G.GetAvatarByIdResponseVariant12, object>?, global::G.GetAvatarByIdResponse2>> GetAvatarByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}