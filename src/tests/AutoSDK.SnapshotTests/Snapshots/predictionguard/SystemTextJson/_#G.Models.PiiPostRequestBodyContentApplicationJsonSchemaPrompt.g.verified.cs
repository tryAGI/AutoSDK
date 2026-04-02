//HintName: G.Models.PiiPostRequestBodyContentApplicationJsonSchemaPrompt.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PiiPostRequestBodyContentApplicationJsonSchemaPrompt : global::System.IEquatable<PiiPostRequestBodyContentApplicationJsonSchemaPrompt>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; init; }
#else
        public string? PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1))]
#endif
        public bool IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 => PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2))]
#endif
        public bool IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 => PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PiiPostRequestBodyContentApplicationJsonSchemaPrompt(string value) => new PiiPostRequestBodyContentApplicationJsonSchemaPrompt((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(PiiPostRequestBodyContentApplicationJsonSchemaPrompt @this) => @this.PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public PiiPostRequestBodyContentApplicationJsonSchemaPrompt(string? value)
        {
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PiiPostRequestBodyContentApplicationJsonSchemaPrompt(
            string? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
            global::System.Collections.Generic.IList<string>? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2
            )
        {
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1;
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 as object ??
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.ToString() ??
            PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && !IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 || !IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null)
            {
                return piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 && piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null)
            {
                return piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1)
            {
                piiPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.Invoke(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsPiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2)
            {
                piiPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.Invoke(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
                typeof(string),
                PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2,
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
        public bool Equals(PiiPostRequestBodyContentApplicationJsonSchemaPrompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1, other.PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2, other.PiiPostRequestBodyContentApplicationJsonSchemaPromptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PiiPostRequestBodyContentApplicationJsonSchemaPrompt obj1, PiiPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PiiPostRequestBodyContentApplicationJsonSchemaPrompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PiiPostRequestBodyContentApplicationJsonSchemaPrompt obj1, PiiPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PiiPostRequestBodyContentApplicationJsonSchemaPrompt o && Equals(o);
        }
    }
}
