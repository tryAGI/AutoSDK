//HintName: G.Models.WebhookConfigInsecureSsl.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookConfigInsecureSsl : global::System.IEquatable<WebhookConfigInsecureSsl>
    {
        /// <summary>
        /// Determines whether the SSL certificate of the host for `url` will be verified when delivering payloads. Supported values include `0` (verification is performed) and `1` (verification is not performed). The default is `0`. **We strongly recommend not setting this to `1` as you are subject to man-in-the-middle and other attacks.**<br/>
        /// Example: "0"
        /// </summary>
#if NET6_0_OR_GREATER
        public string? WebhookConfigInsecureSslVariant1 { get; init; }
#else
        public string? WebhookConfigInsecureSslVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookConfigInsecureSslVariant1))]
#endif
        public bool IsWebhookConfigInsecureSslVariant1 => WebhookConfigInsecureSslVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? WebhookConfigInsecureSslVariant2 { get; init; }
#else
        public double? WebhookConfigInsecureSslVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookConfigInsecureSslVariant2))]
#endif
        public bool IsWebhookConfigInsecureSslVariant2 => WebhookConfigInsecureSslVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookConfigInsecureSsl(string value) => new WebhookConfigInsecureSsl((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(WebhookConfigInsecureSsl @this) => @this.WebhookConfigInsecureSslVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WebhookConfigInsecureSsl(string? value)
        {
            WebhookConfigInsecureSslVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookConfigInsecureSsl(double value) => new WebhookConfigInsecureSsl((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(WebhookConfigInsecureSsl @this) => @this.WebhookConfigInsecureSslVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WebhookConfigInsecureSsl(double? value)
        {
            WebhookConfigInsecureSslVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WebhookConfigInsecureSsl(
            string? webhookConfigInsecureSslVariant1,
            double? webhookConfigInsecureSslVariant2
            )
        {
            WebhookConfigInsecureSslVariant1 = webhookConfigInsecureSslVariant1;
            WebhookConfigInsecureSslVariant2 = webhookConfigInsecureSslVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebhookConfigInsecureSslVariant2 as object ??
            WebhookConfigInsecureSslVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WebhookConfigInsecureSslVariant1?.ToString() ??
            WebhookConfigInsecureSslVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhookConfigInsecureSslVariant1 && !IsWebhookConfigInsecureSslVariant2 || !IsWebhookConfigInsecureSslVariant1 && IsWebhookConfigInsecureSslVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? webhookConfigInsecureSslVariant1 = null,
            global::System.Func<double?, TResult>? webhookConfigInsecureSslVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookConfigInsecureSslVariant1 && webhookConfigInsecureSslVariant1 != null)
            {
                return webhookConfigInsecureSslVariant1(WebhookConfigInsecureSslVariant1!);
            }
            else if (IsWebhookConfigInsecureSslVariant2 && webhookConfigInsecureSslVariant2 != null)
            {
                return webhookConfigInsecureSslVariant2(WebhookConfigInsecureSslVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? webhookConfigInsecureSslVariant1 = null,
            global::System.Action<double?>? webhookConfigInsecureSslVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookConfigInsecureSslVariant1)
            {
                webhookConfigInsecureSslVariant1?.Invoke(WebhookConfigInsecureSslVariant1!);
            }
            else if (IsWebhookConfigInsecureSslVariant2)
            {
                webhookConfigInsecureSslVariant2?.Invoke(WebhookConfigInsecureSslVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WebhookConfigInsecureSslVariant1,
                typeof(string),
                WebhookConfigInsecureSslVariant2,
                typeof(double),
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
        public bool Equals(WebhookConfigInsecureSsl other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(WebhookConfigInsecureSslVariant1, other.WebhookConfigInsecureSslVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(WebhookConfigInsecureSslVariant2, other.WebhookConfigInsecureSslVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookConfigInsecureSsl obj1, WebhookConfigInsecureSsl obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookConfigInsecureSsl>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookConfigInsecureSsl obj1, WebhookConfigInsecureSsl obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookConfigInsecureSsl o && Equals(o);
        }
    }
}
