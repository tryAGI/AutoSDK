//HintName: G.IDescriptorClient.DescriptorStartConvertFieldTypeJob.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// StartConvertFieldTypeJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="fieldId"></param>
        /// <param name="newFieldType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorStartConvertFieldTypeJobAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? setId = default,
            global::System.Guid? fieldId = default,
            int? newFieldType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}