//HintName: G.Models.Prompt.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Prompt : global::System.IEquatable<Prompt>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>? PromptVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>? PromptVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptVariant1))]
#endif
        public bool IsPromptVariant1 => PromptVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>? PromptVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>? PromptVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptVariant2))]
#endif
        public bool IsPromptVariant2 => PromptVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Prompt(global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt> value) => new Prompt((global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>?(Prompt @this) => @this.PromptVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Prompt(global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>? value)
        {
            PromptVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Prompt(global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt> value) => new Prompt((global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>?(Prompt @this) => @this.PromptVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Prompt(global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>? value)
        {
            PromptVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Prompt(
            global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>? promptVariant1,
            global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>? promptVariant2
            )
        {
            PromptVariant1 = promptVariant1;
            PromptVariant2 = promptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PromptVariant2 as object ??
            PromptVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PromptVariant1?.ToString() ??
            PromptVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPromptVariant1 && !IsPromptVariant2 || !IsPromptVariant1 && IsPromptVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>?, TResult>? promptVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>?, TResult>? promptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVariant1 && promptVariant1 != null)
            {
                return promptVariant1(PromptVariant1!);
            }
            else if (IsPromptVariant2 && promptVariant2 != null)
            {
                return promptVariant2(PromptVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>?>? promptVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>?>? promptVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVariant1)
            {
                promptVariant1?.Invoke(PromptVariant1!);
            }
            else if (IsPromptVariant2)
            {
                promptVariant2?.Invoke(PromptVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PromptVariant1,
                typeof(global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>),
                PromptVariant2,
                typeof(global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>),
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
        public bool Equals(Prompt other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.PromptVariant12, global::G.ChatPrompt>?>.Default.Equals(PromptVariant1, other.PromptVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.PromptVariant22, global::G.TextPrompt>?>.Default.Equals(PromptVariant2, other.PromptVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Prompt obj1, Prompt obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Prompt>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Prompt obj1, Prompt obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Prompt o && Equals(o);
        }
    }
}
