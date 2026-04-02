//HintName: G.Models.ResponsesRequestProviderOrderItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestProviderOrderItems : global::System.IEquatable<ResponsesRequestProviderOrderItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderName? ProviderName { get; init; }
#else
        public global::G.ProviderName? ProviderName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderName))]
#endif
        public bool IsProviderName => ProviderName != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponsesRequestProviderOrderItemsVariant2 { get; init; }
#else
        public string? ResponsesRequestProviderOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestProviderOrderItemsVariant2))]
#endif
        public bool IsResponsesRequestProviderOrderItemsVariant2 => ResponsesRequestProviderOrderItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOrderItems(global::G.ProviderName value) => new ResponsesRequestProviderOrderItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ResponsesRequestProviderOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOrderItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOrderItems(string value) => new ResponsesRequestProviderOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestProviderOrderItems @this) => @this.ResponsesRequestProviderOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOrderItems(string? value)
        {
            ResponsesRequestProviderOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOrderItems(
            global::G.ProviderName? providerName,
            string? responsesRequestProviderOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            ResponsesRequestProviderOrderItemsVariant2 = responsesRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestProviderOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ResponsesRequestProviderOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsResponsesRequestProviderOrderItemsVariant2 || !IsProviderName && IsResponsesRequestProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? responsesRequestProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName && providerName != null)
            {
                return providerName(ProviderName!);
            }
            else if (IsResponsesRequestProviderOrderItemsVariant2 && responsesRequestProviderOrderItemsVariant2 != null)
            {
                return responsesRequestProviderOrderItemsVariant2(ResponsesRequestProviderOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? responsesRequestProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsResponsesRequestProviderOrderItemsVariant2)
            {
                responsesRequestProviderOrderItemsVariant2?.Invoke(ResponsesRequestProviderOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderName,
                typeof(global::G.ProviderName),
                ResponsesRequestProviderOrderItemsVariant2,
                typeof(string),
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
        public bool Equals(ResponsesRequestProviderOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestProviderOrderItemsVariant2, other.ResponsesRequestProviderOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestProviderOrderItems obj1, ResponsesRequestProviderOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestProviderOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestProviderOrderItems obj1, ResponsesRequestProviderOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestProviderOrderItems o && Equals(o);
        }
    }
}
