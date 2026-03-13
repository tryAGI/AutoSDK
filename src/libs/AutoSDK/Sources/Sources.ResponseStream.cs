using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateResponseStream(Settings settings)
    {
        return $@"
#nullable enable

namespace {settings.Namespace}
{{
    internal sealed class ResponseStream : global::System.IO.Stream
    {{
        private readonly global::System.Net.Http.HttpResponseMessage _response;
        private readonly global::System.IO.Stream _stream;
        private bool _disposed;

        public ResponseStream(
            global::System.Net.Http.HttpResponseMessage response,
            global::System.IO.Stream stream)
        {{
            _response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            _stream = stream ?? throw new global::System.ArgumentNullException(nameof(stream));
        }}

        public override bool CanRead => _stream.CanRead;
        public override bool CanSeek => _stream.CanSeek;
        public override bool CanWrite => _stream.CanWrite;
        public override bool CanTimeout => _stream.CanTimeout;
        public override long Length => _stream.Length;

        public override long Position
        {{
            get => _stream.Position;
            set => _stream.Position = value;
        }}

        public override int ReadTimeout
        {{
            get => _stream.ReadTimeout;
            set => _stream.ReadTimeout = value;
        }}

        public override int WriteTimeout
        {{
            get => _stream.WriteTimeout;
            set => _stream.WriteTimeout = value;
        }}

        public override void Flush() => _stream.Flush();

        public override global::System.Threading.Tasks.Task FlushAsync(
            global::System.Threading.CancellationToken cancellationToken) =>
            _stream.FlushAsync(cancellationToken);

        public override int Read(byte[] buffer, int offset, int count) =>
            _stream.Read(buffer, offset, count);

        public override global::System.Threading.Tasks.Task<int> ReadAsync(
            byte[] buffer,
            int offset,
            int count,
            global::System.Threading.CancellationToken cancellationToken) =>
            _stream.ReadAsync(buffer, offset, count, cancellationToken);

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NET5_0_OR_GREATER
        public override global::System.Threading.Tasks.ValueTask<int> ReadAsync(
            global::System.Memory<byte> buffer,
            global::System.Threading.CancellationToken cancellationToken = default) =>
            _stream.ReadAsync(buffer, cancellationToken);
#endif

        public override long Seek(long offset, global::System.IO.SeekOrigin origin) =>
            _stream.Seek(offset, origin);

        public override void SetLength(long value) =>
            _stream.SetLength(value);

        public override void Write(byte[] buffer, int offset, int count) =>
            _stream.Write(buffer, offset, count);

        public override global::System.Threading.Tasks.Task WriteAsync(
            byte[] buffer,
            int offset,
            int count,
            global::System.Threading.CancellationToken cancellationToken) =>
            _stream.WriteAsync(buffer, offset, count, cancellationToken);

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NET5_0_OR_GREATER
        public override global::System.Threading.Tasks.ValueTask WriteAsync(
            global::System.ReadOnlyMemory<byte> buffer,
            global::System.Threading.CancellationToken cancellationToken = default) =>
            _stream.WriteAsync(buffer, cancellationToken);
#endif

        protected override void Dispose(bool disposing)
        {{
            if (!_disposed && disposing)
            {{
                _disposed = true;
                _stream.Dispose();
                _response.Dispose();
            }}

            base.Dispose(disposing);
        }}

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NET5_0_OR_GREATER
        public override async global::System.Threading.Tasks.ValueTask DisposeAsync()
        {{
            if (_disposed)
            {{
                return;
            }}

            _disposed = true;
            await _stream.DisposeAsync().ConfigureAwait(false);
            _response.Dispose();
            await base.DisposeAsync().ConfigureAwait(false);
        }}
#endif
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
