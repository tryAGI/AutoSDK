//HintName: G.Models.Config.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The MCP server configuration (Stdio, SSE, or Streamable HTTP)
    /// </summary>
    public readonly partial struct Config : global::System.IEquatable<Config>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; }

        /// <summary>
        /// Create a new Stdio MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateStdioMCPServer? Stdio { get; init; }
#else
        public global::G.CreateStdioMCPServer? Stdio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stdio))]
#endif
        public bool IsStdio => Stdio != null;

        /// <summary>
        /// Create a new SSE MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateSSEMCPServer? Sse { get; init; }
#else
        public global::G.CreateSSEMCPServer? Sse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sse))]
#endif
        public bool IsSse => Sse != null;

        /// <summary>
        /// Create a new Streamable HTTP MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateStreamableHTTPMCPServer? StreamableHttp { get; init; }
#else
        public global::G.CreateStreamableHTTPMCPServer? StreamableHttp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamableHttp))]
#endif
        public bool IsStreamableHttp => StreamableHttp != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::G.CreateStdioMCPServer value) => new Config((global::G.CreateStdioMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateStdioMCPServer?(Config @this) => @this.Stdio;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::G.CreateStdioMCPServer? value)
        {
            Stdio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::G.CreateSSEMCPServer value) => new Config((global::G.CreateSSEMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateSSEMCPServer?(Config @this) => @this.Sse;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::G.CreateSSEMCPServer? value)
        {
            Sse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config(global::G.CreateStreamableHTTPMCPServer value) => new Config((global::G.CreateStreamableHTTPMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateStreamableHTTPMCPServer?(Config @this) => @this.StreamableHttp;

        /// <summary>
        /// 
        /// </summary>
        public Config(global::G.CreateStreamableHTTPMCPServer? value)
        {
            StreamableHttp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config(
            global::G.CreateMCPServerRequestConfigDiscriminatorMcpServerType? mcpServerType,
            global::G.CreateStdioMCPServer? stdio,
            global::G.CreateSSEMCPServer? sse,
            global::G.CreateStreamableHTTPMCPServer? streamableHttp
            )
        {
            McpServerType = mcpServerType;

            Stdio = stdio;
            Sse = sse;
            StreamableHttp = streamableHttp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StreamableHttp as object ??
            Sse as object ??
            Stdio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Stdio?.ToString() ??
            Sse?.ToString() ??
            StreamableHttp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStdio && !IsSse && !IsStreamableHttp || !IsStdio && IsSse && !IsStreamableHttp || !IsStdio && !IsSse && IsStreamableHttp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateStdioMCPServer?, TResult>? stdio = null,
            global::System.Func<global::G.CreateSSEMCPServer?, TResult>? sse = null,
            global::System.Func<global::G.CreateStreamableHTTPMCPServer?, TResult>? streamableHttp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio && stdio != null)
            {
                return stdio(Stdio!);
            }
            else if (IsSse && sse != null)
            {
                return sse(Sse!);
            }
            else if (IsStreamableHttp && streamableHttp != null)
            {
                return streamableHttp(StreamableHttp!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateStdioMCPServer?>? stdio = null,
            global::System.Action<global::G.CreateSSEMCPServer?>? sse = null,
            global::System.Action<global::G.CreateStreamableHTTPMCPServer?>? streamableHttp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStdio)
            {
                stdio?.Invoke(Stdio!);
            }
            else if (IsSse)
            {
                sse?.Invoke(Sse!);
            }
            else if (IsStreamableHttp)
            {
                streamableHttp?.Invoke(StreamableHttp!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Stdio,
                typeof(global::G.CreateStdioMCPServer),
                Sse,
                typeof(global::G.CreateSSEMCPServer),
                StreamableHttp,
                typeof(global::G.CreateStreamableHTTPMCPServer),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Config other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateStdioMCPServer?>.Default.Equals(Stdio, other.Stdio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateSSEMCPServer?>.Default.Equals(Sse, other.Sse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateStreamableHTTPMCPServer?>.Default.Equals(StreamableHttp, other.StreamableHttp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config obj1, Config obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config obj1, Config obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config o && Equals(o);
        }
    }
}
