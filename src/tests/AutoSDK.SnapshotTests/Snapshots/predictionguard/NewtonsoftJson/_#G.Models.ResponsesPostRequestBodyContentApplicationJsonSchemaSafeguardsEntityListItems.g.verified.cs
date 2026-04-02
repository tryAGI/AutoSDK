//HintName: G.Models.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems : global::System.IEquatable<ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 { get; init; }
#else
        public string? ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1))]
#endif
        public bool IsResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 => ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems(string value) => new ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems @this) => @this.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems(string? value)
        {
            ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? responsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 && responsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 != null)
            {
                return responsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? responsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1)
            {
                responsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1?.Invoke(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1,
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
        public bool Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1, other.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems obj1, ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems o && Equals(o);
        }
    }
}
