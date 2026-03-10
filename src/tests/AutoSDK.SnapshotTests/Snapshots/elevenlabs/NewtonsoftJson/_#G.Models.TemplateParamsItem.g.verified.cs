//HintName: G.Models.TemplateParamsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TemplateParamsItem : global::System.IEquatable<TemplateParamsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateHeaderComponentParams? Header { get; init; }
#else
        public global::G.WhatsAppTemplateHeaderComponentParams? Header { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Header))]
#endif
        public bool IsHeader => Header != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateBodyComponentParams? Body { get; init; }
#else
        public global::G.WhatsAppTemplateBodyComponentParams? Body { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Body))]
#endif
        public bool IsBody => Body != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WhatsAppTemplateButtonComponentParams? Button { get; init; }
#else
        public global::G.WhatsAppTemplateButtonComponentParams? Button { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Button))]
#endif
        public bool IsButton => Button != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplateParamsItem(global::G.WhatsAppTemplateHeaderComponentParams value) => new TemplateParamsItem((global::G.WhatsAppTemplateHeaderComponentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateHeaderComponentParams?(TemplateParamsItem @this) => @this.Header;

        /// <summary>
        /// 
        /// </summary>
        public TemplateParamsItem(global::G.WhatsAppTemplateHeaderComponentParams? value)
        {
            Header = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplateParamsItem(global::G.WhatsAppTemplateBodyComponentParams value) => new TemplateParamsItem((global::G.WhatsAppTemplateBodyComponentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateBodyComponentParams?(TemplateParamsItem @this) => @this.Body;

        /// <summary>
        /// 
        /// </summary>
        public TemplateParamsItem(global::G.WhatsAppTemplateBodyComponentParams? value)
        {
            Body = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplateParamsItem(global::G.WhatsAppTemplateButtonComponentParams value) => new TemplateParamsItem((global::G.WhatsAppTemplateButtonComponentParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WhatsAppTemplateButtonComponentParams?(TemplateParamsItem @this) => @this.Button;

        /// <summary>
        /// 
        /// </summary>
        public TemplateParamsItem(global::G.WhatsAppTemplateButtonComponentParams? value)
        {
            Button = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplateParamsItem(
            global::G.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType? type,
            global::G.WhatsAppTemplateHeaderComponentParams? header,
            global::G.WhatsAppTemplateBodyComponentParams? body,
            global::G.WhatsAppTemplateButtonComponentParams? button
            )
        {
            Type = type;

            Header = header;
            Body = body;
            Button = button;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Button as object ??
            Body as object ??
            Header as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Header?.ToString() ??
            Body?.ToString() ??
            Button?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsHeader && !IsBody && !IsButton || !IsHeader && IsBody && !IsButton || !IsHeader && !IsBody && IsButton;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WhatsAppTemplateHeaderComponentParams?, TResult>? header = null,
            global::System.Func<global::G.WhatsAppTemplateBodyComponentParams?, TResult>? body = null,
            global::System.Func<global::G.WhatsAppTemplateButtonComponentParams?, TResult>? button = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHeader && header != null)
            {
                return header(Header!);
            }
            else if (IsBody && body != null)
            {
                return body(Body!);
            }
            else if (IsButton && button != null)
            {
                return button(Button!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WhatsAppTemplateHeaderComponentParams?>? header = null,
            global::System.Action<global::G.WhatsAppTemplateBodyComponentParams?>? body = null,
            global::System.Action<global::G.WhatsAppTemplateButtonComponentParams?>? button = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsHeader)
            {
                header?.Invoke(Header!);
            }
            else if (IsBody)
            {
                body?.Invoke(Body!);
            }
            else if (IsButton)
            {
                button?.Invoke(Button!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Header,
                typeof(global::G.WhatsAppTemplateHeaderComponentParams),
                Body,
                typeof(global::G.WhatsAppTemplateBodyComponentParams),
                Button,
                typeof(global::G.WhatsAppTemplateButtonComponentParams),
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
        public bool Equals(TemplateParamsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateHeaderComponentParams?>.Default.Equals(Header, other.Header) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateBodyComponentParams?>.Default.Equals(Body, other.Body) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WhatsAppTemplateButtonComponentParams?>.Default.Equals(Button, other.Button) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TemplateParamsItem obj1, TemplateParamsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateParamsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TemplateParamsItem obj1, TemplateParamsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateParamsItem o && Equals(o);
        }
    }
}
