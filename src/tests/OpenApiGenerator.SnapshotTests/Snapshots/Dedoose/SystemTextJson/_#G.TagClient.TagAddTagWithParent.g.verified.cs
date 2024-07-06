//HintName: G.TagClient.TagAddTagWithParent.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        /// <summary>
        /// AddTagWithParent.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="proejctId"></param>
        /// <param name="parentTagId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="allowDecimalWeights"></param>
        /// <param name="color"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Tag> TagAddTagWithParentAsync(
            string token,
            string proejctId,
            string parentTagId,
            string title,
            string description,
            bool isWeighted,
            double weightMin,
            double weightMax,
            double weightDefault,
            bool allowDecimalWeights,
            double color,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tag/addtagwithparent?proejctId={proejctId}&parentTagId={parentTagId}&title={title}&description={description}&isWeighted={isWeighted}&weightMin={weightMin}&weightMax={weightMax}&weightDefault={weightDefault}&allowDecimalWeights={allowDecimalWeights}&color={color}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Tag?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}