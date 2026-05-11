using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GeneratePageableHelpers(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#pragma warning disable CS1591
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Trim/AOT-friendly helpers that wrap paged API responses into <c>IAsyncEnumerable&lt;T&gt;</c>
    /// streams. Detects auto-paging shape from a fetch-page delegate plus extractors for the
    /// items collection and either the <c>has_more</c> flag (offset) or the next cursor value.
    /// </summary>
    public static class AutoSDKPager
    {{
        /// <summary>
        /// Paginates through offset/page-number-style endpoints. Calls <paramref name=""fetchPage""/>
        /// repeatedly with an incrementing page number until the page returns no items, or the
        /// optional <paramref name=""hasMore""/> predicate returns false.
        /// </summary>
        /// <typeparam name=""TPage""></typeparam>
        /// <typeparam name=""TItem""></typeparam>
        /// <param name=""fetchPage"">Async fetch for the page at the given 1-based page number.</param>
        /// <param name=""extractItems"">Pulls the item collection from a page response.</param>
        /// <param name=""hasMore"">Optional <c>has_more</c> / <c>has_next</c> predicate. When null, paging stops on an empty page.</param>
        /// <param name=""initialPage"">First page number to request (defaults to 1).</param>
        /// <param name=""cancellationToken""></param>
        public static async global::System.Collections.Generic.IAsyncEnumerable<TItem> OffsetAsync<TPage, TItem>(
            global::System.Func<int, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TPage>> fetchPage,
            global::System.Func<TPage, global::System.Collections.Generic.IEnumerable<TItem>?> extractItems,
            global::System.Func<TPage, bool>? hasMore = null,
            int initialPage = 1,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation]
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            fetchPage = fetchPage ?? throw new global::System.ArgumentNullException(nameof(fetchPage));
            extractItems = extractItems ?? throw new global::System.ArgumentNullException(nameof(extractItems));

            var page = initialPage;
            while (true)
            {{
                cancellationToken.ThrowIfCancellationRequested();

                var response = await fetchPage(page, cancellationToken).ConfigureAwait(false);
                if (response is null)
                {{
                    yield break;
                }}

                var items = extractItems(response);
                var emittedAny = false;
                if (items is not null)
                {{
                    foreach (var item in items)
                    {{
                        emittedAny = true;
                        yield return item;
                    }}
                }}

                if (hasMore is null)
                {{
                    if (!emittedAny)
                    {{
                        yield break;
                    }}
                }}
                else if (!hasMore(response))
                {{
                    yield break;
                }}

                page++;
            }}
        }}

        /// <summary>
        /// Paginates through cursor/next-page-token-style endpoints. Calls <paramref name=""fetchPage""/>
        /// with the cursor returned by the previous page until <paramref name=""extractNextCursor""/>
        /// returns null or whitespace.
        /// </summary>
        /// <typeparam name=""TPage""></typeparam>
        /// <typeparam name=""TItem""></typeparam>
        /// <param name=""fetchPage"">Async fetch for the page at the given cursor.</param>
        /// <param name=""extractItems"">Pulls the item collection from a page response.</param>
        /// <param name=""extractNextCursor"">Pulls the next cursor from a page response. Returning null/whitespace stops paging.</param>
        /// <param name=""initialCursor"">First cursor to send (defaults to null).</param>
        /// <param name=""cancellationToken""></param>
        public static async global::System.Collections.Generic.IAsyncEnumerable<TItem> CursorAsync<TPage, TItem>(
            global::System.Func<string?, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TPage>> fetchPage,
            global::System.Func<TPage, global::System.Collections.Generic.IEnumerable<TItem>?> extractItems,
            global::System.Func<TPage, string?> extractNextCursor,
            string? initialCursor = null,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation]
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            fetchPage = fetchPage ?? throw new global::System.ArgumentNullException(nameof(fetchPage));
            extractItems = extractItems ?? throw new global::System.ArgumentNullException(nameof(extractItems));
            extractNextCursor = extractNextCursor ?? throw new global::System.ArgumentNullException(nameof(extractNextCursor));

            var cursor = initialCursor;
            while (true)
            {{
                cancellationToken.ThrowIfCancellationRequested();

                var response = await fetchPage(cursor, cancellationToken).ConfigureAwait(false);
                if (response is null)
                {{
                    yield break;
                }}

                var items = extractItems(response);
                if (items is not null)
                {{
                    foreach (var item in items)
                    {{
                        yield return item;
                    }}
                }}

                var next = extractNextCursor(response);
                if (string.IsNullOrWhiteSpace(next) || string.Equals(next, cursor, global::System.StringComparison.Ordinal))
                {{
                    yield break;
                }}

                cursor = next;
            }}
        }}

        /// <summary>
        /// Paginates through RFC 5988 <c>Link</c>-header-style endpoints (GitHub, Apify, etc.).
        /// Calls <paramref name=""fetchPage""/> with the URL returned by the previous page's
        /// <c>Link: &lt;url&gt;; rel=""next""</c> header until the header is missing.
        /// </summary>
        /// <typeparam name=""TPage""></typeparam>
        /// <typeparam name=""TItem""></typeparam>
        /// <param name=""fetchPage"">Async fetch for the page at the given URL (null for the first request).</param>
        /// <param name=""extractItems"">Pulls the item collection from the response body.</param>
        /// <param name=""extractLinkHeader"">Pulls the raw <c>Link</c> header values from the response. Typically <c>response =&gt; response.Headers.TryGetValue(""Link"", out var v) ? v : null</c>.</param>
        /// <param name=""initialUrl"">First URL to send (defaults to null, meaning the underlying fetch should hit the base endpoint).</param>
        /// <param name=""linkRel"">The <c>rel</c> attribute to match. Defaults to <c>""next""</c>.</param>
        /// <param name=""cancellationToken""></param>
        public static async global::System.Collections.Generic.IAsyncEnumerable<TItem> LinkHeaderAsync<TPage, TItem>(
            global::System.Func<string?, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TPage>> fetchPage,
            global::System.Func<TPage, global::System.Collections.Generic.IEnumerable<TItem>?> extractItems,
            global::System.Func<TPage, global::System.Collections.Generic.IEnumerable<string>?> extractLinkHeader,
            string? initialUrl = null,
            string linkRel = ""next"",
            [global::System.Runtime.CompilerServices.EnumeratorCancellation]
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            fetchPage = fetchPage ?? throw new global::System.ArgumentNullException(nameof(fetchPage));
            extractItems = extractItems ?? throw new global::System.ArgumentNullException(nameof(extractItems));
            extractLinkHeader = extractLinkHeader ?? throw new global::System.ArgumentNullException(nameof(extractLinkHeader));
            if (string.IsNullOrWhiteSpace(linkRel))
            {{
                linkRel = ""next"";
            }}

            var url = initialUrl;
            while (true)
            {{
                cancellationToken.ThrowIfCancellationRequested();

                var response = await fetchPage(url, cancellationToken).ConfigureAwait(false);
                if (response is null)
                {{
                    yield break;
                }}

                var items = extractItems(response);
                if (items is not null)
                {{
                    foreach (var item in items)
                    {{
                        yield return item;
                    }}
                }}

                var headerValues = extractLinkHeader(response);
                var nextUrl = ParseLinkHeaderRel(headerValues, linkRel);
                if (string.IsNullOrWhiteSpace(nextUrl) || string.Equals(nextUrl, url, global::System.StringComparison.Ordinal))
                {{
                    yield break;
                }}

                url = nextUrl;
            }}
        }}

        /// <summary>
        /// Convenience overload that pulls items from <see cref=""AutoSDKHttpResponse{{T}}.Body""/>
        /// and reads <c>Link</c> headers from <see cref=""AutoSDKHttpResponse.Headers""/> without
        /// requiring callers to pass an <c>extractLinkHeader</c> lambda.
        /// </summary>
        /// <typeparam name=""TPage""></typeparam>
        /// <typeparam name=""TItem""></typeparam>
        /// <param name=""fetchPage"">Async fetch that returns the response wrapper for the given URL.</param>
        /// <param name=""extractItems"">Pulls the item collection from the response body.</param>
        /// <param name=""initialUrl""></param>
        /// <param name=""linkRel""></param>
        /// <param name=""cancellationToken""></param>
        public static global::System.Collections.Generic.IAsyncEnumerable<TItem> LinkHeaderAsync<TPage, TItem>(
            global::System.Func<string?, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::{settings.Namespace}.AutoSDKHttpResponse<TPage>>> fetchPage,
            global::System.Func<TPage, global::System.Collections.Generic.IEnumerable<TItem>?> extractItems,
            string? initialUrl = null,
            string linkRel = ""next"",
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            extractItems = extractItems ?? throw new global::System.ArgumentNullException(nameof(extractItems));
            return LinkHeaderAsync<global::{settings.Namespace}.AutoSDKHttpResponse<TPage>, TItem>(
                fetchPage: fetchPage,
                extractItems: response => response.Body is null
                    ? null
                    : extractItems(response.Body),
                extractLinkHeader: response => response.Headers != null &&
                    response.Headers.TryGetValue(""Link"", out var values)
                        ? values
                        : null,
                initialUrl: initialUrl,
                linkRel: linkRel,
                cancellationToken: cancellationToken);
        }}

        /// <summary>
        /// Parses RFC 5988 <c>Link</c> header values and returns the URL whose <c>rel</c>
        /// attribute matches <paramref name=""linkRel""/>. Multiple link values may be passed
        /// either as separate strings or comma-separated within a single string. Returns null
        /// when no matching link is found.
        /// </summary>
        public static string? ParseLinkHeaderRel(
            global::System.Collections.Generic.IEnumerable<string>? linkHeaderValues,
            string linkRel)
        {{
            if (linkHeaderValues is null || string.IsNullOrWhiteSpace(linkRel))
            {{
                return null;
            }}

            foreach (var header in linkHeaderValues)
            {{
                if (string.IsNullOrWhiteSpace(header))
                {{
                    continue;
                }}

                // Split on commas that aren't inside <...> brackets. RFC 5988 allows multiple
                // comma-separated link values per header, and HttpClient surfaces multi-value
                // headers as separate enumerable entries too.
                var depth = 0;
                var partStart = 0;
                for (var i = 0; i <= header.Length; i++)
                {{
                    if (i < header.Length && header[i] == '<')
                    {{
                        depth++;
                        continue;
                    }}

                    if (i < header.Length && header[i] == '>')
                    {{
                        depth = global::System.Math.Max(0, depth - 1);
                        continue;
                    }}

                    if (i == header.Length || (header[i] == ',' && depth == 0))
                    {{
                        var part = header.Substring(partStart, i - partStart).Trim();
                        partStart = i + 1;

                        if (part.Length == 0 || part[0] != '<')
                        {{
                            continue;
                        }}

                        var endBracket = part.IndexOf('>');
                        if (endBracket <= 1)
                        {{
                            continue;
                        }}

                        var url = part.Substring(1, endBracket - 1);
                        var attrs = part.Substring(endBracket + 1);
                        if (MatchesLinkRel(attrs, linkRel))
                        {{
                            return url;
                        }}
                    }}
                }}
            }}

            return null;
        }}

        private static bool MatchesLinkRel(string attrSection, string linkRel)
        {{
            foreach (var attr in attrSection.Split(';'))
            {{
                var trimmed = attr.Trim();
                if (!trimmed.StartsWith(""rel"", global::System.StringComparison.OrdinalIgnoreCase))
                {{
                    continue;
                }}

                var equalsIndex = trimmed.IndexOf('=');
                if (equalsIndex < 0)
                {{
                    continue;
                }}

                var value = trimmed.Substring(equalsIndex + 1).Trim().Trim('""');
                // rel values can be space-separated (RFC 8288 allows multiple rel tokens).
                foreach (var token in value.Split(' '))
                {{
                    if (string.Equals(token, linkRel, global::System.StringComparison.OrdinalIgnoreCase))
                    {{
                        return true;
                    }}
                }}
            }}

            return false;
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
