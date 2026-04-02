//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaStop.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionsPostRequestBodyContentApplicationJsonSchemaStop : global::System.IEquatable<CompletionsPostRequestBodyContentApplicationJsonSchemaStop>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 { get; init; }
#else
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1))]
#endif
        public bool IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 => CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2))]
#endif
        public bool IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 => CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionsPostRequestBodyContentApplicationJsonSchemaStop(string value) => new CompletionsPostRequestBodyContentApplicationJsonSchemaStop((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CompletionsPostRequestBodyContentApplicationJsonSchemaStop @this) => @this.CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaStop(string? value)
        {
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaStop(
            string? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1,
            global::System.Collections.Generic.IList<string>? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2
            )
        {
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1;
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 as object ??
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1?.ToString() ??
            CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && !IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 || !IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 && completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 != null)
            {
                return completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1!);
            }
            else if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 && completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 != null)
            {
                return completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1)
            {
                completionsPostRequestBodyContentApplicationJsonSchemaStopVariant1?.Invoke(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1!);
            }
            else if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2)
            {
                completionsPostRequestBodyContentApplicationJsonSchemaStopVariant2?.Invoke(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1,
                typeof(string),
                CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2,
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaStop other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1, other.CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2, other.CompletionsPostRequestBodyContentApplicationJsonSchemaStopVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionsPostRequestBodyContentApplicationJsonSchemaStop obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaStop obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionsPostRequestBodyContentApplicationJsonSchemaStop>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionsPostRequestBodyContentApplicationJsonSchemaStop obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaStop obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionsPostRequestBodyContentApplicationJsonSchemaStop o && Equals(o);
        }
    }
}
