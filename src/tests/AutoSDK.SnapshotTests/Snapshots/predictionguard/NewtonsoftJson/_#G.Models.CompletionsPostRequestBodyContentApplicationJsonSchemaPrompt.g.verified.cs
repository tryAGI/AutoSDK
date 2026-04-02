//HintName: G.Models.CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt : global::System.IEquatable<CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; init; }
#else
        public string? CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1))]
#endif
        public bool IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 => CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2))]
#endif
        public bool IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 => CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt(string value) => new CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt @this) => @this.CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt(string? value)
        {
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt(
            string? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
            global::System.Collections.Generic.IList<string>? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2
            )
        {
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1;
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 as object ??
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.ToString() ??
            CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && !IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 || !IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null)
            {
                return completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 && completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null)
            {
                return completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1)
            {
                completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.Invoke(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsCompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2)
            {
                completionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.Invoke(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
                typeof(string),
                CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2,
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
        public bool Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1, other.CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2, other.CompletionsPostRequestBodyContentApplicationJsonSchemaPromptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt obj1, CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt o && Equals(o);
        }
    }
}
