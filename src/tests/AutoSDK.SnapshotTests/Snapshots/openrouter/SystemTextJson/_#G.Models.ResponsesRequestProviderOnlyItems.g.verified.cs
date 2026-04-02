//HintName: G.Models.ResponsesRequestProviderOnlyItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestProviderOnlyItems : global::System.IEquatable<ResponsesRequestProviderOnlyItems>
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
        public string? ResponsesRequestProviderOnlyItemsVariant2 { get; init; }
#else
        public string? ResponsesRequestProviderOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestProviderOnlyItemsVariant2))]
#endif
        public bool IsResponsesRequestProviderOnlyItemsVariant2 => ResponsesRequestProviderOnlyItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOnlyItems(global::G.ProviderName value) => new ResponsesRequestProviderOnlyItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ResponsesRequestProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOnlyItems(string value) => new ResponsesRequestProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestProviderOnlyItems @this) => @this.ResponsesRequestProviderOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(string? value)
        {
            ResponsesRequestProviderOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(
            global::G.ProviderName? providerName,
            string? responsesRequestProviderOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            ResponsesRequestProviderOnlyItemsVariant2 = responsesRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestProviderOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ResponsesRequestProviderOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsResponsesRequestProviderOnlyItemsVariant2 || !IsProviderName && IsResponsesRequestProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? responsesRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsResponsesRequestProviderOnlyItemsVariant2 && responsesRequestProviderOnlyItemsVariant2 != null)
            {
                return responsesRequestProviderOnlyItemsVariant2(ResponsesRequestProviderOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? responsesRequestProviderOnlyItemsVariant2 = null,
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
            else if (IsResponsesRequestProviderOnlyItemsVariant2)
            {
                responsesRequestProviderOnlyItemsVariant2?.Invoke(ResponsesRequestProviderOnlyItemsVariant2!);
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
                ResponsesRequestProviderOnlyItemsVariant2,
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
        public bool Equals(ResponsesRequestProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestProviderOnlyItemsVariant2, other.ResponsesRequestProviderOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestProviderOnlyItems obj1, ResponsesRequestProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestProviderOnlyItems obj1, ResponsesRequestProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestProviderOnlyItems o && Equals(o);
        }
    }
}
