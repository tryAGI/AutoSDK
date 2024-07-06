using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GeneratePolyfills(Settings settings)
    {
        if (!settings.GeneratePolyfills)
        {
            return string.Empty;
        }
        
        return $@"
#if !NET6_0_OR_GREATER
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// 
    /// </summary>
    public partial static class OpenApiGeneratorPolyfills
    {{
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""content""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns></returns>
        public static Task<string> ReadAsStringAsync(
            this global::System.Net.Http.HttpContent content,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            
            return content.ReadAsStringAsync();
        }}
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""content""></param>
        /// <param name=""cancellationToken""></param>
        /// <returns></returns>
        public static Task<global::System.IO.Stream> ReadAsStreamAsync(
            this global::System.Net.Http.HttpContent content,
            global::System.Threading.CancellationToken cancellationToken)
        {{
            content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            
            return content.ReadAsStreamAsync();
        }}
    }}
}}
#endif".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}