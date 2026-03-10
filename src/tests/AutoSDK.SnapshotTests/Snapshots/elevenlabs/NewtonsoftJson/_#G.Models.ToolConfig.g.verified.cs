//HintName: G.Models.ToolConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for the tool
    /// </summary>
    public readonly partial struct ToolConfig : global::System.IEquatable<ToolConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ToolRequestModelToolConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigInput? Webhook { get; init; }
#else
        public global::G.WebhookToolConfigInput? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigInput? Client { get; init; }
#else
        public global::G.ClientToolConfigInput? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfigInput? System { get; init; }
#else
        public global::G.SystemToolConfigInput? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolConfigInput? Mcp { get; init; }
#else
        public global::G.MCPToolConfigInput? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfig(global::G.WebhookToolConfigInput value) => new ToolConfig((global::G.WebhookToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigInput?(ToolConfig @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::G.WebhookToolConfigInput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfig(global::G.ClientToolConfigInput value) => new ToolConfig((global::G.ClientToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigInput?(ToolConfig @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::G.ClientToolConfigInput? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfig(global::G.SystemToolConfigInput value) => new ToolConfig((global::G.SystemToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfigInput?(ToolConfig @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::G.SystemToolConfigInput? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfig(global::G.MCPToolConfigInput value) => new ToolConfig((global::G.MCPToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolConfigInput?(ToolConfig @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::G.MCPToolConfigInput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(
            global::G.ToolRequestModelToolConfigDiscriminatorType? type,
            global::G.WebhookToolConfigInput? webhook,
            global::G.ClientToolConfigInput? client,
            global::G.SystemToolConfigInput? system,
            global::G.MCPToolConfigInput? mcp
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
            Mcp = mcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mcp as object ??
            System as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() ??
            System?.ToString() ??
            Mcp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem && !IsMcp || !IsWebhook && IsClient && !IsSystem && !IsMcp || !IsWebhook && !IsClient && IsSystem && !IsMcp || !IsWebhook && !IsClient && !IsSystem && IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WebhookToolConfigInput?, TResult>? webhook = null,
            global::System.Func<global::G.ClientToolConfigInput?, TResult>? client = null,
            global::System.Func<global::G.SystemToolConfigInput?, TResult>? system = null,
            global::System.Func<global::G.MCPToolConfigInput?, TResult>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsClient && client != null)
            {
                return client(Client!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WebhookToolConfigInput?>? webhook = null,
            global::System.Action<global::G.ClientToolConfigInput?>? client = null,
            global::System.Action<global::G.SystemToolConfigInput?>? system = null,
            global::System.Action<global::G.MCPToolConfigInput?>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::G.WebhookToolConfigInput),
                Client,
                typeof(global::G.ClientToolConfigInput),
                System,
                typeof(global::G.SystemToolConfigInput),
                Mcp,
                typeof(global::G.MCPToolConfigInput),
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
        public bool Equals(ToolConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigInput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigInput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfigInput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolConfigInput?>.Default.Equals(Mcp, other.Mcp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolConfig obj1, ToolConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolConfig obj1, ToolConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolConfig o && Equals(o);
        }
    }
}
