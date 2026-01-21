//HintName: G.Models.ToolsItem3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem3 : global::System.IEquatable<ToolsItem3>
    {
        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigOutput? WebhookToolConfigOutput { get; init; }
#else
        public global::G.WebhookToolConfigOutput? WebhookToolConfigOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookToolConfigOutput))]
#endif
        public bool IsWebhookToolConfigOutput => WebhookToolConfigOutput != null;

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigOutput? ClientToolConfigOutput { get; init; }
#else
        public global::G.ClientToolConfigOutput? ClientToolConfigOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolConfigOutput))]
#endif
        public bool IsClientToolConfigOutput => ClientToolConfigOutput != null;

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server<br/>
        /// Example: {"type":"system"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfigOutput? SystemToolConfigOutput { get; init; }
#else
        public global::G.SystemToolConfigOutput? SystemToolConfigOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemToolConfigOutput))]
#endif
        public bool IsSystemToolConfigOutput => SystemToolConfigOutput != null;

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolConfigOutput? MCPToolConfigOutput { get; init; }
#else
        public global::G.MCPToolConfigOutput? MCPToolConfigOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolConfigOutput))]
#endif
        public bool IsMCPToolConfigOutput => MCPToolConfigOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.WebhookToolConfigOutput value) => new ToolsItem3((global::G.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigOutput?(ToolsItem3 @this) => @this.WebhookToolConfigOutput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.WebhookToolConfigOutput? value)
        {
            WebhookToolConfigOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.ClientToolConfigOutput value) => new ToolsItem3((global::G.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigOutput?(ToolsItem3 @this) => @this.ClientToolConfigOutput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.ClientToolConfigOutput? value)
        {
            ClientToolConfigOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.SystemToolConfigOutput value) => new ToolsItem3((global::G.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfigOutput?(ToolsItem3 @this) => @this.SystemToolConfigOutput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.SystemToolConfigOutput? value)
        {
            SystemToolConfigOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.MCPToolConfigOutput value) => new ToolsItem3((global::G.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolConfigOutput?(ToolsItem3 @this) => @this.MCPToolConfigOutput;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.MCPToolConfigOutput? value)
        {
            MCPToolConfigOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(
            global::G.WebhookToolConfigOutput? webhookToolConfigOutput,
            global::G.ClientToolConfigOutput? clientToolConfigOutput,
            global::G.SystemToolConfigOutput? systemToolConfigOutput,
            global::G.MCPToolConfigOutput? mCPToolConfigOutput
            )
        {
            WebhookToolConfigOutput = webhookToolConfigOutput;
            ClientToolConfigOutput = clientToolConfigOutput;
            SystemToolConfigOutput = systemToolConfigOutput;
            MCPToolConfigOutput = mCPToolConfigOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPToolConfigOutput as object ??
            SystemToolConfigOutput as object ??
            ClientToolConfigOutput as object ??
            WebhookToolConfigOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebhookToolConfigOutput?.ToString() ??
            ClientToolConfigOutput?.ToString() ??
            SystemToolConfigOutput?.ToString() ??
            MCPToolConfigOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhookToolConfigOutput && !IsClientToolConfigOutput && !IsSystemToolConfigOutput && !IsMCPToolConfigOutput || !IsWebhookToolConfigOutput && IsClientToolConfigOutput && !IsSystemToolConfigOutput && !IsMCPToolConfigOutput || !IsWebhookToolConfigOutput && !IsClientToolConfigOutput && IsSystemToolConfigOutput && !IsMCPToolConfigOutput || !IsWebhookToolConfigOutput && !IsClientToolConfigOutput && !IsSystemToolConfigOutput && IsMCPToolConfigOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookToolConfigOutput?, TResult>? webhookToolConfigOutput = null,
            global::System.Func<global::G.ClientToolConfigOutput?, TResult>? clientToolConfigOutput = null,
            global::System.Func<global::G.SystemToolConfigOutput?, TResult>? systemToolConfigOutput = null,
            global::System.Func<global::G.MCPToolConfigOutput?, TResult>? mCPToolConfigOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfigOutput && webhookToolConfigOutput != null)
            {
                return webhookToolConfigOutput(WebhookToolConfigOutput!);
            }
            else if (IsClientToolConfigOutput && clientToolConfigOutput != null)
            {
                return clientToolConfigOutput(ClientToolConfigOutput!);
            }
            else if (IsSystemToolConfigOutput && systemToolConfigOutput != null)
            {
                return systemToolConfigOutput(SystemToolConfigOutput!);
            }
            else if (IsMCPToolConfigOutput && mCPToolConfigOutput != null)
            {
                return mCPToolConfigOutput(MCPToolConfigOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookToolConfigOutput?>? webhookToolConfigOutput = null,
            global::System.Action<global::G.ClientToolConfigOutput?>? clientToolConfigOutput = null,
            global::System.Action<global::G.SystemToolConfigOutput?>? systemToolConfigOutput = null,
            global::System.Action<global::G.MCPToolConfigOutput?>? mCPToolConfigOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfigOutput)
            {
                webhookToolConfigOutput?.Invoke(WebhookToolConfigOutput!);
            }
            else if (IsClientToolConfigOutput)
            {
                clientToolConfigOutput?.Invoke(ClientToolConfigOutput!);
            }
            else if (IsSystemToolConfigOutput)
            {
                systemToolConfigOutput?.Invoke(SystemToolConfigOutput!);
            }
            else if (IsMCPToolConfigOutput)
            {
                mCPToolConfigOutput?.Invoke(MCPToolConfigOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookToolConfigOutput,
                typeof(global::G.WebhookToolConfigOutput),
                ClientToolConfigOutput,
                typeof(global::G.ClientToolConfigOutput),
                SystemToolConfigOutput,
                typeof(global::G.SystemToolConfigOutput),
                MCPToolConfigOutput,
                typeof(global::G.MCPToolConfigOutput),
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
        public bool Equals(ToolsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigOutput?>.Default.Equals(WebhookToolConfigOutput, other.WebhookToolConfigOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigOutput?>.Default.Equals(ClientToolConfigOutput, other.ClientToolConfigOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfigOutput?>.Default.Equals(SystemToolConfigOutput, other.SystemToolConfigOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolConfigOutput?>.Default.Equals(MCPToolConfigOutput, other.MCPToolConfigOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem3 o && Equals(o);
        }
    }
}
