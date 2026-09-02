using Octokit;
using Octokit.Internal;

namespace tryAGI.Extensions.HttpClientFactory.Octokit;

internal sealed class OctokitHttpClientAdapter(IHttpClient inner) : IHttpClient
{
    public async Task<IResponse> Send(
        IRequest request,
        CancellationToken cancellationToken,
        Func<object, object>? preprocessResponseBody = null)
    {
        var scopedCancellation = OctokitRequestCancellation.Current;
        if (!scopedCancellation.CanBeCanceled)
        {
            return await inner.Send(request, cancellationToken, preprocessResponseBody).ConfigureAwait(false);
        }

        if (!cancellationToken.CanBeCanceled || cancellationToken == scopedCancellation)
        {
            return await inner.Send(request, scopedCancellation, preprocessResponseBody).ConfigureAwait(false);
        }

        using var linked = CancellationTokenSource.CreateLinkedTokenSource(
            cancellationToken,
            scopedCancellation);
        return await inner.Send(request, linked.Token, preprocessResponseBody).ConfigureAwait(false);
    }

    public void SetRequestTimeout(TimeSpan timeout) => inner.SetRequestTimeout(timeout);

    public void Dispose() => inner.Dispose();
}

internal static class OctokitRequestCancellation
{
    private static readonly AsyncLocal<CancellationToken?> CurrentToken = new();

    public static CancellationToken Current => CurrentToken.Value ?? CancellationToken.None;

    public static IDisposable Push(CancellationToken cancellationToken)
    {
        var previous = CurrentToken.Value;
        CurrentToken.Value = cancellationToken;
        return new Scope(previous);
    }

    private sealed class Scope(CancellationToken? previous) : IDisposable
    {
        private bool _disposed;

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            CurrentToken.Value = previous;
            _disposed = true;
        }
    }
}
