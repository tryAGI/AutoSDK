//HintName: G.Models.ToolDetailsVariant12.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolDetailsVariant12 : global::System.IEquatable<ToolDetailsVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallClientDetails? Client { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallClientDetails? Client { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallMCPDetails? Mcp { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallMCPDetails? Mcp { get; }
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
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? ApiIntegrationWebhook { get; init; }
#else
        public global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? ApiIntegrationWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationWebhook))]
#endif
        public bool IsApiIntegrationWebhook => ApiIntegrationWebhook != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallWebhookDetails value) => new ToolDetailsVariant12((global::G.ConversationHistoryTranscriptToolCallWebhookDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallWebhookDetails?(ToolDetailsVariant12 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallWebhookDetails? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallClientDetails value) => new ToolDetailsVariant12((global::G.ConversationHistoryTranscriptToolCallClientDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallClientDetails?(ToolDetailsVariant12 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallClientDetails? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallMCPDetails value) => new ToolDetailsVariant12((global::G.ConversationHistoryTranscriptToolCallMCPDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallMCPDetails?(ToolDetailsVariant12 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallMCPDetails? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails value) => new ToolDetailsVariant12((global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?(ToolDetailsVariant12 @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant12(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolDetailsVariant12(
            global::G.ConversationHistoryTranscriptToolCallCommonModelOutputToolDetailsVariant1DiscriminatorType? type,
            global::G.ConversationHistoryTranscriptToolCallWebhookDetails? webhook,
            global::G.ConversationHistoryTranscriptToolCallClientDetails? client,
            global::G.ConversationHistoryTranscriptToolCallMCPDetails? mcp,
            global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? apiIntegrationWebhook
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            Mcp = mcp;
            ApiIntegrationWebhook = apiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiIntegrationWebhook as object ??
            Mcp as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() ??
            Mcp?.ToString() ??
            ApiIntegrationWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsMcp && !IsApiIntegrationWebhook || !IsWebhook && IsClient && !IsMcp && !IsApiIntegrationWebhook || !IsWebhook && !IsClient && IsMcp && !IsApiIntegrationWebhook || !IsWebhook && !IsClient && !IsMcp && IsApiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?, TResult>? webhook = null,
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallClientDetails?, TResult>? client = null,
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallMCPDetails?, TResult>? mcp = null,
            global::System.Func<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?, TResult>? apiIntegrationWebhook = null,
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
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsApiIntegrationWebhook && apiIntegrationWebhook != null)
            {
                return apiIntegrationWebhook(ApiIntegrationWebhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?>? webhook = null,
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallClientDetails?>? client = null,
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallMCPDetails?>? mcp = null,
            global::System.Action<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?>? apiIntegrationWebhook = null,
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
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsApiIntegrationWebhook)
            {
                apiIntegrationWebhook?.Invoke(ApiIntegrationWebhook!);
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
                typeof(global::G.ConversationHistoryTranscriptToolCallWebhookDetails),
                Client,
                typeof(global::G.ConversationHistoryTranscriptToolCallClientDetails),
                Mcp,
                typeof(global::G.ConversationHistoryTranscriptToolCallMCPDetails),
                ApiIntegrationWebhook,
                typeof(global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails),
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
        public bool Equals(ToolDetailsVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallWebhookDetails?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallClientDetails?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallMCPDetails?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?>.Default.Equals(ApiIntegrationWebhook, other.ApiIntegrationWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolDetailsVariant12 obj1, ToolDetailsVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolDetailsVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolDetailsVariant12 obj1, ToolDetailsVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolDetailsVariant12 o && Equals(o);
        }
    }
}
