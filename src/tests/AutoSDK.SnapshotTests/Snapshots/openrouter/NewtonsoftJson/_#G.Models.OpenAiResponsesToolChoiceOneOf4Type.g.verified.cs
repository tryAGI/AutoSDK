//HintName: G.Models.OpenAiResponsesToolChoiceOneOf4Type.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAiResponsesToolChoiceOneOf4Type : global::System.IEquatable<OpenAiResponsesToolChoiceOneOf4Type>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoiceOneOf4Type0? OpenAiResponsesToolChoiceOneOf4Type0 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoiceOneOf4Type0? OpenAiResponsesToolChoiceOneOf4Type0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoiceOneOf4Type0))]
#endif
        public bool IsOpenAiResponsesToolChoiceOneOf4Type0 => OpenAiResponsesToolChoiceOneOf4Type0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoiceOneOf4Type1? OpenAiResponsesToolChoiceOneOf4Type1 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoiceOneOf4Type1? OpenAiResponsesToolChoiceOneOf4Type1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoiceOneOf4Type1))]
#endif
        public bool IsOpenAiResponsesToolChoiceOneOf4Type1 => OpenAiResponsesToolChoiceOneOf4Type1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponsesToolChoiceOneOf4Type(global::G.OpenAiResponsesToolChoiceOneOf4Type0 value) => new OpenAiResponsesToolChoiceOneOf4Type((global::G.OpenAiResponsesToolChoiceOneOf4Type0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoiceOneOf4Type0?(OpenAiResponsesToolChoiceOneOf4Type @this) => @this.OpenAiResponsesToolChoiceOneOf4Type0;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponsesToolChoiceOneOf4Type(global::G.OpenAiResponsesToolChoiceOneOf4Type0? value)
        {
            OpenAiResponsesToolChoiceOneOf4Type0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiResponsesToolChoiceOneOf4Type(global::G.OpenAiResponsesToolChoiceOneOf4Type1 value) => new OpenAiResponsesToolChoiceOneOf4Type((global::G.OpenAiResponsesToolChoiceOneOf4Type1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoiceOneOf4Type1?(OpenAiResponsesToolChoiceOneOf4Type @this) => @this.OpenAiResponsesToolChoiceOneOf4Type1;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponsesToolChoiceOneOf4Type(global::G.OpenAiResponsesToolChoiceOneOf4Type1? value)
        {
            OpenAiResponsesToolChoiceOneOf4Type1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAiResponsesToolChoiceOneOf4Type(
            global::G.OpenAiResponsesToolChoiceOneOf4Type0? openAiResponsesToolChoiceOneOf4Type0,
            global::G.OpenAiResponsesToolChoiceOneOf4Type1? openAiResponsesToolChoiceOneOf4Type1
            )
        {
            OpenAiResponsesToolChoiceOneOf4Type0 = openAiResponsesToolChoiceOneOf4Type0;
            OpenAiResponsesToolChoiceOneOf4Type1 = openAiResponsesToolChoiceOneOf4Type1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAiResponsesToolChoiceOneOf4Type1 as object ??
            OpenAiResponsesToolChoiceOneOf4Type0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiResponsesToolChoiceOneOf4Type0?.ToValueString() ??
            OpenAiResponsesToolChoiceOneOf4Type1?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiResponsesToolChoiceOneOf4Type0 && !IsOpenAiResponsesToolChoiceOneOf4Type1 || !IsOpenAiResponsesToolChoiceOneOf4Type0 && IsOpenAiResponsesToolChoiceOneOf4Type1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAiResponsesToolChoiceOneOf4Type0?, TResult>? openAiResponsesToolChoiceOneOf4Type0 = null,
            global::System.Func<global::G.OpenAiResponsesToolChoiceOneOf4Type1?, TResult>? openAiResponsesToolChoiceOneOf4Type1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponsesToolChoiceOneOf4Type0 && openAiResponsesToolChoiceOneOf4Type0 != null)
            {
                return openAiResponsesToolChoiceOneOf4Type0(OpenAiResponsesToolChoiceOneOf4Type0!);
            }
            else if (IsOpenAiResponsesToolChoiceOneOf4Type1 && openAiResponsesToolChoiceOneOf4Type1 != null)
            {
                return openAiResponsesToolChoiceOneOf4Type1(OpenAiResponsesToolChoiceOneOf4Type1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAiResponsesToolChoiceOneOf4Type0?>? openAiResponsesToolChoiceOneOf4Type0 = null,
            global::System.Action<global::G.OpenAiResponsesToolChoiceOneOf4Type1?>? openAiResponsesToolChoiceOneOf4Type1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponsesToolChoiceOneOf4Type0)
            {
                openAiResponsesToolChoiceOneOf4Type0?.Invoke(OpenAiResponsesToolChoiceOneOf4Type0!);
            }
            else if (IsOpenAiResponsesToolChoiceOneOf4Type1)
            {
                openAiResponsesToolChoiceOneOf4Type1?.Invoke(OpenAiResponsesToolChoiceOneOf4Type1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiResponsesToolChoiceOneOf4Type0,
                typeof(global::G.OpenAiResponsesToolChoiceOneOf4Type0),
                OpenAiResponsesToolChoiceOneOf4Type1,
                typeof(global::G.OpenAiResponsesToolChoiceOneOf4Type1),
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
        public bool Equals(OpenAiResponsesToolChoiceOneOf4Type other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoiceOneOf4Type0?>.Default.Equals(OpenAiResponsesToolChoiceOneOf4Type0, other.OpenAiResponsesToolChoiceOneOf4Type0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoiceOneOf4Type1?>.Default.Equals(OpenAiResponsesToolChoiceOneOf4Type1, other.OpenAiResponsesToolChoiceOneOf4Type1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiResponsesToolChoiceOneOf4Type obj1, OpenAiResponsesToolChoiceOneOf4Type obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiResponsesToolChoiceOneOf4Type>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiResponsesToolChoiceOneOf4Type obj1, OpenAiResponsesToolChoiceOneOf4Type obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiResponsesToolChoiceOneOf4Type o && Equals(o);
        }
    }
}
