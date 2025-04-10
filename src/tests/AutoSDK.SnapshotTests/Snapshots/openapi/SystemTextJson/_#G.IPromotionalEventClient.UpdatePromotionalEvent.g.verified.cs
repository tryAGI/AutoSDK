//HintName: G.IPromotionalEventClient.UpdatePromotionalEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IPromotionalEventClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromotionalEventAsync(
            global::G.PromotionalEventForUpdateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="promotionalEventImages"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="promotionTypeEnumId"></param>
        /// <param name="createdDateUtc"></param>
        /// <param name="isActive"></param>
        /// <param name="customField1"></param>
        /// <param name="customField2"></param>
        /// <param name="customField3"></param>
        /// <param name="customField4"></param>
        /// <param name="customField5"></param>
        /// <param name="customField6"></param>
        /// <param name="customField7"></param>
        /// <param name="customField8"></param>
        /// <param name="customField9"></param>
        /// <param name="customField10"></param>
        /// <param name="customField11"></param>
        /// <param name="customField12"></param>
        /// <param name="customField13"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePromotionalEventAsync(
            string? currentCulture = default,
            global::System.Collections.Generic.IList<global::G.PromotionalEventForCreatePromotionalEventImageRequestDto>? promotionalEventImages = default,
            long? id = default,
            string? name = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            int? promotionTypeEnumId = default,
            global::System.DateTime? createdDateUtc = default,
            bool? isActive = default,
            string? customField1 = default,
            string? customField2 = default,
            string? customField3 = default,
            string? customField4 = default,
            string? customField5 = default,
            string? customField6 = default,
            string? customField7 = default,
            string? customField8 = default,
            string? customField9 = default,
            string? customField10 = default,
            string? customField11 = default,
            string? customField12 = default,
            string? customField13 = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}