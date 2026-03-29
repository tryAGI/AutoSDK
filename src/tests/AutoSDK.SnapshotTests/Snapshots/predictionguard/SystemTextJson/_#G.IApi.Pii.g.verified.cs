//HintName: G.IApi.Pii.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// PII<br/>
        /// Replace personal information such as names, SSNs, and emails in a given text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PiiResponse200> PiiAsync(

            global::G.PiiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// PII<br/>
        /// Replace personal information such as names, SSNs, and emails in a given text.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="replace">
        /// Whether to replace personal information.
        /// </param>
        /// <param name="replaceMethod">
        /// The method to use (random, fake, category, mask).
        /// </param>
        /// <param name="entityList">
        /// An array of entity types that the PII check should ignore.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PiiResponse200> PiiAsync(
            global::G.PiiPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool replace,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}