//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems : global::System.IEquatable<CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 { get; init; }
#else
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1))]
#endif
        public bool IsCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 => CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems(string value) => new CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems @this) => @this.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems(string? value)
        {
            CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? completionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 && completionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 != null)
            {
                return completionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? completionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1)
            {
                completionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1?.Invoke(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1,
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
        public bool Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1, other.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsVariant1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems o && Equals(o);
        }
    }
}
