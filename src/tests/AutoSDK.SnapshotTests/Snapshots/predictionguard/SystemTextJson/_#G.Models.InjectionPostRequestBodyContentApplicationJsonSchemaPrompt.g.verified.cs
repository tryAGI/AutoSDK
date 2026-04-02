//HintName: G.Models.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InjectionPostRequestBodyContentApplicationJsonSchemaPrompt : global::System.IEquatable<InjectionPostRequestBodyContentApplicationJsonSchemaPrompt>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; init; }
#else
        public string? InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1))]
#endif
        public bool IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 => InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2))]
#endif
        public bool IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 => InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InjectionPostRequestBodyContentApplicationJsonSchemaPrompt(string value) => new InjectionPostRequestBodyContentApplicationJsonSchemaPrompt((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InjectionPostRequestBodyContentApplicationJsonSchemaPrompt @this) => @this.InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public InjectionPostRequestBodyContentApplicationJsonSchemaPrompt(string? value)
        {
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InjectionPostRequestBodyContentApplicationJsonSchemaPrompt(
            string? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
            global::System.Collections.Generic.IList<string>? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2
            )
        {
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1;
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 as object ??
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.ToString() ??
            InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && !IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 || !IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 && injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 != null)
            {
                return injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 && injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 != null)
            {
                return injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1)
            {
                injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1?.Invoke(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1!);
            }
            else if (IsInjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2)
            {
                injectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2?.Invoke(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1,
                typeof(string),
                InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2,
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
        public bool Equals(InjectionPostRequestBodyContentApplicationJsonSchemaPrompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1, other.InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2, other.InjectionPostRequestBodyContentApplicationJsonSchemaPromptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InjectionPostRequestBodyContentApplicationJsonSchemaPrompt obj1, InjectionPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InjectionPostRequestBodyContentApplicationJsonSchemaPrompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InjectionPostRequestBodyContentApplicationJsonSchemaPrompt obj1, InjectionPostRequestBodyContentApplicationJsonSchemaPrompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InjectionPostRequestBodyContentApplicationJsonSchemaPrompt o && Equals(o);
        }
    }
}
