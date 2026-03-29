//HintName: G.Models.Config4.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The MCP server configuration updates (Stdio, SSE, or Streamable HTTP)
    /// </summary>
    public readonly partial struct Config4 : global::System.IEquatable<Config4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType? McpServerType { get; }

        /// <summary>
        /// Update schema for Stdio MCP server - all fields optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LettaSchemasMcpServerUpdateStdioMCPServer? Stdio { get; init; }
#else
        public global::G.LettaSchemasMcpServerUpdateStdioMCPServer? Stdio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stdio))]
#endif
        public bool IsStdio => Stdio != null;

        /// <summary>
        /// Update schema for SSE MCP server - all fields optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LettaSchemasMcpServerUpdateSSEMCPServer? Sse { get; init; }
#else
        public global::G.LettaSchemasMcpServerUpdateSSEMCPServer? Sse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sse))]
#endif
        public bool IsSse => Sse != null;

        /// <summary>
        /// Update schema for Streamable HTTP MCP server - all fields optional
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? StreamableHttp { get; init; }
#else
        public global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? StreamableHttp { get; }
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
        public static implicit operator Config4(global::G.LettaSchemasMcpServerUpdateStdioMCPServer value) => new Config4((global::G.LettaSchemasMcpServerUpdateStdioMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LettaSchemasMcpServerUpdateStdioMCPServer?(Config4 @this) => @this.Stdio;

        /// <summary>
        /// 
        /// </summary>
        public Config4(global::G.LettaSchemasMcpServerUpdateStdioMCPServer? value)
        {
            Stdio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config4(global::G.LettaSchemasMcpServerUpdateSSEMCPServer value) => new Config4((global::G.LettaSchemasMcpServerUpdateSSEMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LettaSchemasMcpServerUpdateSSEMCPServer?(Config4 @this) => @this.Sse;

        /// <summary>
        /// 
        /// </summary>
        public Config4(global::G.LettaSchemasMcpServerUpdateSSEMCPServer? value)
        {
            Sse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Config4(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer value) => new Config4((global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?(Config4 @this) => @this.StreamableHttp;

        /// <summary>
        /// 
        /// </summary>
        public Config4(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? value)
        {
            StreamableHttp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Config4(
            global::G.UpdateMCPServerRequestConfigDiscriminatorMcpServerType? mcpServerType,
            global::G.LettaSchemasMcpServerUpdateStdioMCPServer? stdio,
            global::G.LettaSchemasMcpServerUpdateSSEMCPServer? sse,
            global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer? streamableHttp
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
            global::System.Func<global::G.LettaSchemasMcpServerUpdateStdioMCPServer?, TResult>? stdio = null,
            global::System.Func<global::G.LettaSchemasMcpServerUpdateSSEMCPServer?, TResult>? sse = null,
            global::System.Func<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?, TResult>? streamableHttp = null,
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
            global::System.Action<global::G.LettaSchemasMcpServerUpdateStdioMCPServer?>? stdio = null,
            global::System.Action<global::G.LettaSchemasMcpServerUpdateSSEMCPServer?>? sse = null,
            global::System.Action<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?>? streamableHttp = null,
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
                typeof(global::G.LettaSchemasMcpServerUpdateStdioMCPServer),
                Sse,
                typeof(global::G.LettaSchemasMcpServerUpdateSSEMCPServer),
                StreamableHttp,
                typeof(global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer),
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
        public bool Equals(Config4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LettaSchemasMcpServerUpdateStdioMCPServer?>.Default.Equals(Stdio, other.Stdio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LettaSchemasMcpServerUpdateSSEMCPServer?>.Default.Equals(Sse, other.Sse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LettaSchemasMcpServerUpdateStreamableHTTPMCPServer?>.Default.Equals(StreamableHttp, other.StreamableHttp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Config4 obj1, Config4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Config4 obj1, Config4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config4 o && Equals(o);
        }
    }
}
