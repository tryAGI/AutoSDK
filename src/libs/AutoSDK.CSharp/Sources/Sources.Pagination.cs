using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GeneratePaginationSupport(CSharpSettings settings)
    {
        return $@"
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Represents a paginated API response together with traversal helpers.
    /// </summary>
    public sealed class AutoSDKPage<TItem, TResponse> : global::{settings.Namespace}.AutoSDKHttpResponse<TResponse>
    {{
        private readonly global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::{settings.Namespace}.AutoSDKPage<TItem, TResponse>?>>? _getNextPageAsync;

        /// <summary>
        /// Initializes a new paginated response wrapper.
        /// </summary>
        /// <param name=""statusCode"">The HTTP status code.</param>
        /// <param name=""headers"">The response headers.</param>
        /// <param name=""body"">The deserialized response body.</param>
        /// <param name=""items"">The items extracted from the response body.</param>
        /// <param name=""nextCursor"">The next cursor token, when available.</param>
        /// <param name=""nextPageUri"">The absolute next-page URI, when available.</param>
        /// <param name=""currentPage"">The current page number, when available.</param>
        /// <param name=""totalPages"">The total page count, when available.</param>
        /// <param name=""getNextPageAsync"">The delegate used to resolve the next page.</param>
        public AutoSDKPage(
            global::System.Net.HttpStatusCode statusCode,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IEnumerable<string>> headers,
            TResponse body,
            global::System.Collections.Generic.IReadOnlyList<TItem> items,
            string? nextCursor = null,
            global::System.Uri? nextPageUri = null,
            int? currentPage = null,
            int? totalPages = null,
            global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::{settings.Namespace}.AutoSDKPage<TItem, TResponse>?>>? getNextPageAsync = null)
            : base(statusCode, headers, body)
        {{
            Items = items ?? global::System.Array.Empty<TItem>();
            NextCursor = nextCursor;
            NextPageUri = nextPageUri;
            CurrentPage = currentPage;
            TotalPages = totalPages;
            _getNextPageAsync = getNextPageAsync;
        }}

        /// <summary>
        /// Gets the items extracted from the current page.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<TItem> Items {{ get; }}

        /// <summary>
        /// Gets the next cursor token, when the pagination scheme exposes one.
        /// </summary>
        public string? NextCursor {{ get; }}

        /// <summary>
        /// Gets the absolute next-page URI, when the pagination scheme exposes one.
        /// </summary>
        public global::System.Uri? NextPageUri {{ get; }}

        /// <summary>
        /// Gets the current page number, when available.
        /// </summary>
        public int? CurrentPage {{ get; }}

        /// <summary>
        /// Gets the total page count, when available.
        /// </summary>
        public int? TotalPages {{ get; }}

        /// <summary>
        /// Gets a value indicating whether another page can be requested.
        /// </summary>
        public bool HasNextPage => _getNextPageAsync != null;

        /// <summary>
        /// Resolves the next page when one is available.
        /// </summary>
        /// <param name=""cancellationToken"">The token used to cancel the next-page request.</param>
        /// <returns>The next page, or <see langword=""null""/> when pagination is exhausted.</returns>
        public global::System.Threading.Tasks.Task<global::{settings.Namespace}.AutoSDKPage<TItem, TResponse>?> GetNextPageAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {{
            return _getNextPageAsync == null
                ? global::System.Threading.Tasks.Task.FromResult<global::{settings.Namespace}.AutoSDKPage<TItem, TResponse>?>(null)
                : _getNextPageAsync(cancellationToken);
        }}

        /// <summary>
        /// Enumerates items from the current page and any subsequent pages.
        /// </summary>
        /// <param name=""cancellationToken"">The token used to cancel pagination traversal.</param>
        /// <returns>An async sequence of paginated items.</returns>
        public async global::System.Collections.Generic.IAsyncEnumerable<TItem> AsAsyncEnumerable(
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {{
            global::{settings.Namespace}.AutoSDKPage<TItem, TResponse>? current = this;
            while (current != null)
            {{
                foreach (var item in current.Items)
                {{
                    cancellationToken.ThrowIfCancellationRequested();
                    yield return item;
                }}

                current = await current.GetNextPageAsync(cancellationToken).ConfigureAwait(false);
            }}
        }}
    }}

    internal static class AutoSDKPaginationSupport
    {{
        internal static global::System.Collections.Generic.IReadOnlyList<TItem> ExtractItems<TItem>(
            object? body,
            string path,
            bool isTopLevelArray)
        {{
            object? value = body;
            if (!isTopLevelArray &&
                !global::{settings.Namespace}.AutoSDKObjectPathSupport.TryResolveValue(body, path, out value))
            {{
                return global::System.Array.Empty<TItem>();
            }}

            if (value is null || value is string)
            {{
                return global::System.Array.Empty<TItem>();
            }}

            if (value is global::System.Collections.Generic.IReadOnlyList<TItem> readOnlyList)
            {{
                return readOnlyList;
            }}

            if (value is global::System.Collections.Generic.IEnumerable<TItem> typedEnumerable)
            {{
                return global::System.Linq.Enumerable.ToArray(typedEnumerable);
            }}

            if (value is not global::System.Collections.IEnumerable enumerable)
            {{
                return global::System.Array.Empty<TItem>();
            }}

            var items = new global::System.Collections.Generic.List<TItem>();
            foreach (var item in enumerable)
            {{
                if (item is TItem typedItem)
                {{
                    items.Add(typedItem);
                    continue;
                }}

                if (TryCoerceValue(item, out TItem coercedItem))
                {{
                    items.Add(coercedItem);
                }}
            }}

            return items;
        }}

        internal static string? GetBodyString(object? body, string path)
        {{
            return global::{settings.Namespace}.AutoSDKObjectPathSupport.TryResolveValue(body, path, out var value)
                ? global::{settings.Namespace}.AutoSDKObjectPathSupport.ConvertValueToString(value)
                : null;
        }}

        internal static int? GetBodyInt(object? body, string path)
        {{
            return global::{settings.Namespace}.AutoSDKObjectPathSupport.TryResolveValue(body, path, out var value)
                ? ToNullableInt(value)
                : null;
        }}

        internal static global::System.Uri? GetBodyUri(object? body, string path)
        {{
            var text = GetBodyString(body, path);
            return global::System.Uri.TryCreate(text, global::System.UriKind.Absolute, out var uri)
                ? uri
                : null;
        }}

        internal static string? GetHeaderString(global::{settings.Namespace}.AutoSDKHttpResponse response, string headerName)
        {{
            if (response.Headers.TryGetValue(headerName, out var values))
            {{
                return global::System.Linq.Enumerable.FirstOrDefault(values);
            }}

            return null;
        }}

        internal static int? GetHeaderInt(global::{settings.Namespace}.AutoSDKHttpResponse response, string headerName)
        {{
            return ToNullableInt(GetHeaderString(response, headerName));
        }}

        internal static global::System.Uri? GetHeaderUri(global::{settings.Namespace}.AutoSDKHttpResponse response, string headerName)
        {{
            var text = GetHeaderString(response, headerName);
            return global::System.Uri.TryCreate(text, global::System.UriKind.Absolute, out var uri)
                ? uri
                : null;
        }}

        internal static int? ToNullableInt(object? value)
        {{
            return TryCoerceValue(value, out int? intValue)
                ? intValue
                : null;
        }}

        internal static TTarget CoerceValue<TTarget>(object? value)
        {{
            return TryCoerceValue(value, out TTarget result)
                ? result
                : throw new global::System.InvalidOperationException($""Failed to convert pagination value '{{value}}' to '{{typeof(TTarget).FullName}}'."");
        }}

        internal static bool TryCoerceValue<TTarget>(object? value, out TTarget result)
        {{
            result = default!;

            var targetType = typeof(TTarget);
            var underlyingType = global::System.Nullable.GetUnderlyingType(targetType);
            var effectiveType = underlyingType ?? targetType;

            if (value == null)
            {{
                return underlyingType != null || !targetType.IsValueType;
            }}

            if (value is TTarget typedValue)
            {{
                result = typedValue;
                return true;
            }}

            var stringValue = global::{settings.Namespace}.AutoSDKObjectPathSupport.ConvertValueToString(value);
            if (effectiveType == typeof(string))
            {{
                return TryWrapValue(stringValue ?? string.Empty, targetType, out result);
            }}

            if (effectiveType == typeof(int) &&
                int.TryParse(stringValue, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out var intValue))
            {{
                return TryWrapValue(intValue, targetType, out result);
            }}

            if (effectiveType == typeof(long) &&
                long.TryParse(stringValue, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out var longValue))
            {{
                return TryWrapValue(longValue, targetType, out result);
            }}

            if (effectiveType == typeof(decimal) &&
                decimal.TryParse(stringValue, global::System.Globalization.NumberStyles.Number, global::System.Globalization.CultureInfo.InvariantCulture, out var decimalValue))
            {{
                return TryWrapValue(decimalValue, targetType, out result);
            }}

            if (effectiveType == typeof(double) &&
                double.TryParse(stringValue, global::System.Globalization.NumberStyles.Float | global::System.Globalization.NumberStyles.AllowThousands, global::System.Globalization.CultureInfo.InvariantCulture, out var doubleValue))
            {{
                return TryWrapValue(doubleValue, targetType, out result);
            }}

            if (effectiveType == typeof(bool) &&
                bool.TryParse(stringValue, out var booleanValue))
            {{
                return TryWrapValue(booleanValue, targetType, out result);
            }}

            if (effectiveType == typeof(global::System.DateTime) &&
                global::System.DateTime.TryParse(stringValue, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.RoundtripKind, out var dateTimeValue))
            {{
                return TryWrapValue(dateTimeValue, targetType, out result);
            }}

            if (effectiveType == typeof(global::System.DateTimeOffset) &&
                global::System.DateTimeOffset.TryParse(stringValue, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.RoundtripKind, out var dateTimeOffsetValue))
            {{
                return TryWrapValue(dateTimeOffsetValue, targetType, out result);
            }}

            if (effectiveType == typeof(global::System.Guid) &&
                global::System.Guid.TryParse(stringValue, out var guidValue))
            {{
                return TryWrapValue(guidValue, targetType, out result);
            }}

            if (effectiveType.IsEnum &&
                !string.IsNullOrWhiteSpace(stringValue))
            {{
                try
                {{
                    var enumValue = global::System.Enum.Parse(effectiveType, stringValue, ignoreCase: true);
                    return TryWrapValue(enumValue, targetType, out result);
                }}
                catch (global::System.ArgumentException)
                {{
                }}
            }}

            try
            {{
                var converted = global::System.Convert.ChangeType(value, effectiveType, global::System.Globalization.CultureInfo.InvariantCulture);
                if (converted != null && TryWrapValue(converted, targetType, out result))
                {{
                    return true;
                }}
            }}
            catch (global::System.Exception)
            {{
            }}

            return false;
        }}

        private static bool TryWrapValue<TTarget>(object value, global::System.Type targetType, out TTarget result)
        {{
            try
            {{
                if (value is TTarget typedValue)
                {{
                    result = typedValue;
                    return true;
                }}

                var underlyingType = global::System.Nullable.GetUnderlyingType(targetType);
                if (underlyingType != null)
                {{
                    var boxedNullable = global::System.Activator.CreateInstance(targetType, value);
                    if (boxedNullable is TTarget nullableValue)
                    {{
                        result = nullableValue;
                        return true;
                    }}
                }}
            }}
            catch (global::System.Exception)
            {{
            }}

            result = default!;
            return false;
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
