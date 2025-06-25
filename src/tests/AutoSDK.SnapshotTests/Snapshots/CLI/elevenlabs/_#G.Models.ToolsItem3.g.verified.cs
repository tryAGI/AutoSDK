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
        /// 
        /// </summary>
        public global::G.PromptAgentOutputToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WebhookToolConfigOutput? Webhook { get; init; }
#else
        public global::G.WebhookToolConfigOutput? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.WebhookToolConfigOutput value) => new ToolsItem3((global::G.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WebhookToolConfigOutput?(ToolsItem3 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.WebhookToolConfigOutput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientToolConfigOutput? Client { get; init; }
#else
        public global::G.ClientToolConfigOutput? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.ClientToolConfigOutput value) => new ToolsItem3((global::G.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientToolConfigOutput?(ToolsItem3 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.ClientToolConfigOutput? value)
        {
            Client = value;
        }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SystemToolConfigOutput? System { get; init; }
#else
        public global::G.SystemToolConfigOutput? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::G.SystemToolConfigOutput value) => new ToolsItem3((global::G.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SystemToolConfigOutput?(ToolsItem3 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.SystemToolConfigOutput? value)
        {
            System = value;
        }

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MCPToolConfigOutput? Mcp { get; init; }
#else
        public global::G.MCPToolConfigOutput? Mcp { get; }
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
        public static implicit operator ToolsItem3(global::G.MCPToolConfigOutput value) => new ToolsItem3((global::G.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPToolConfigOutput?(ToolsItem3 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::G.MCPToolConfigOutput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(
            global::G.PromptAgentOutputToolDiscriminatorType? type,
            global::G.WebhookToolConfigOutput? webhook,
            global::G.ClientToolConfigOutput? client,
            global::G.SystemToolConfigOutput? system,
            global::G.MCPToolConfigOutput? mcp
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
            global::System.Func<global::G.WebhookToolConfigOutput?, TResult>? webhook = null,
            global::System.Func<global::G.ClientToolConfigOutput?, TResult>? client = null,
            global::System.Func<global::G.SystemToolConfigOutput?, TResult>? system = null,
            global::System.Func<global::G.MCPToolConfigOutput?, TResult>? mcp = null,
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
            global::System.Action<global::G.WebhookToolConfigOutput?>? webhook = null,
            global::System.Action<global::G.ClientToolConfigOutput?>? client = null,
            global::System.Action<global::G.SystemToolConfigOutput?>? system = null,
            global::System.Action<global::G.MCPToolConfigOutput?>? mcp = null,
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
                typeof(global::G.WebhookToolConfigOutput),
                Client,
                typeof(global::G.ClientToolConfigOutput),
                System,
                typeof(global::G.SystemToolConfigOutput),
                Mcp,
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
                global::System.Collections.Generic.EqualityComparer<global::G.WebhookToolConfigOutput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClientToolConfigOutput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SystemToolConfigOutput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPToolConfigOutput?>.Default.Equals(Mcp, other.Mcp) 
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
