//HintName: G.IDescriptorClient.DescriptorAddDynamicValue.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// AddDynamicValue.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="setId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="fieldId"></param>
        /// <param name="resourceId"></param>
        /// <param name="data"></param>
        /// <param name="optionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DescriptorAddDynamicValueResponse> DescriptorAddDynamicValueAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            global::System.Guid? setId = default,
            global::System.Guid? descriptorId = default,
            global::System.Guid? fieldId = default,
            global::System.Guid? resourceId = default,
            string? data = default,
            global::System.Guid? optionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}