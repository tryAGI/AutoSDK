//HintName: G.Models.ResponsesRequestProviderIgnoreItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestProviderIgnoreItems : global::System.IEquatable<ResponsesRequestProviderIgnoreItems>
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
        public string? ResponsesRequestProviderIgnoreItemsVariant2 { get; init; }
#else
        public string? ResponsesRequestProviderIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestProviderIgnoreItemsVariant2))]
#endif
        public bool IsResponsesRequestProviderIgnoreItemsVariant2 => ResponsesRequestProviderIgnoreItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderIgnoreItems(global::G.ProviderName value) => new ResponsesRequestProviderIgnoreItems((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(ResponsesRequestProviderIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderIgnoreItems(global::G.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderIgnoreItems(string value) => new ResponsesRequestProviderIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestProviderIgnoreItems @this) => @this.ResponsesRequestProviderIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderIgnoreItems(string? value)
        {
            ResponsesRequestProviderIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderIgnoreItems(
            global::G.ProviderName? providerName,
            string? responsesRequestProviderIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            ResponsesRequestProviderIgnoreItemsVariant2 = responsesRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestProviderIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            ResponsesRequestProviderIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsResponsesRequestProviderIgnoreItemsVariant2 || !IsProviderName && IsResponsesRequestProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? responsesRequestProviderIgnoreItemsVariant2 = null,
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
            else if (IsResponsesRequestProviderIgnoreItemsVariant2 && responsesRequestProviderIgnoreItemsVariant2 != null)
            {
                return responsesRequestProviderIgnoreItemsVariant2(ResponsesRequestProviderIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? providerName = null,
            global::System.Action<string?>? responsesRequestProviderIgnoreItemsVariant2 = null,
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
            else if (IsResponsesRequestProviderIgnoreItemsVariant2)
            {
                responsesRequestProviderIgnoreItemsVariant2?.Invoke(ResponsesRequestProviderIgnoreItemsVariant2!);
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
                ResponsesRequestProviderIgnoreItemsVariant2,
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
        public bool Equals(ResponsesRequestProviderIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestProviderIgnoreItemsVariant2, other.ResponsesRequestProviderIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestProviderIgnoreItems obj1, ResponsesRequestProviderIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestProviderIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestProviderIgnoreItems obj1, ResponsesRequestProviderIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestProviderIgnoreItems o && Equals(o);
        }
    }
}
