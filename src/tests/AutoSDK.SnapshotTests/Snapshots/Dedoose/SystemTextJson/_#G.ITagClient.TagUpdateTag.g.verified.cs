//HintName: G.ITagClient.TagUpdateTag.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// UpdateTag.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="isWeighted"></param>
        /// <param name="weightMin"></param>
        /// <param name="weightMax"></param>
        /// <param name="weightDefault"></param>
        /// <param name="sortOrder"></param>
        /// <param name="color"></param>
        /// <param name="allowDecimalWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> TagUpdateTagAsync(
            string? token = default,
            string? projectIdKey = default,
            global::System.Guid? projectId = default,
            global::System.Guid? id = default,
            global::System.Guid? projectIDL = default,
            string? title = default,
            string? description = default,
            bool? isWeighted = default,
            double? weightMin = default,
            double? weightMax = default,
            double? weightDefault = default,
            int? sortOrder = default,
            int? color = default,
            bool? allowDecimalWeight = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}