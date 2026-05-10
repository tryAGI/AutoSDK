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
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
