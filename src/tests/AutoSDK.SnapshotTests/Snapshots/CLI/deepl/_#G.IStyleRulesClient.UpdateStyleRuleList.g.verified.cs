//HintName: G.IStyleRulesClient.UpdateStyleRuleList.g.cs
#nullable enable

namespace G
{
    public partial interface IStyleRulesClient
    {
        /// <summary>
        /// Update a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StyleRuleList> UpdateStyleRuleListAsync(
            string styleId,

            global::G.UpdateStyleRuleListRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a style rule list
        /// </summary>
        /// <param name="styleId"></param>
        /// <param name="name">
        /// Name of the style rule list<br/>
        /// Example: New Technical Documentation Rules
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StyleRuleList> UpdateStyleRuleListAsync(
            string styleId,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}