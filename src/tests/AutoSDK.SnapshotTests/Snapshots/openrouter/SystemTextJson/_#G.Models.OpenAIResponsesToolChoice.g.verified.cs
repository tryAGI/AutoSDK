//HintName: G.Models.OpenAIResponsesToolChoice.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenAIResponsesToolChoice : global::System.IEquatable<OpenAIResponsesToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoice0? OpenAiResponsesToolChoice0 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoice0? OpenAiResponsesToolChoice0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoice0))]
#endif
        public bool IsOpenAiResponsesToolChoice0 => OpenAiResponsesToolChoice0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoice1? OpenAiResponsesToolChoice1 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoice1? OpenAiResponsesToolChoice1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoice1))]
#endif
        public bool IsOpenAiResponsesToolChoice1 => OpenAiResponsesToolChoice1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoice2? OpenAiResponsesToolChoice2 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoice2? OpenAiResponsesToolChoice2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoice2))]
#endif
        public bool IsOpenAiResponsesToolChoice2 => OpenAiResponsesToolChoice2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoice3? OpenAiResponsesToolChoice3 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoice3? OpenAiResponsesToolChoice3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoice3))]
#endif
        public bool IsOpenAiResponsesToolChoice3 => OpenAiResponsesToolChoice3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiResponsesToolChoice4? OpenAiResponsesToolChoice4 { get; init; }
#else
        public global::G.OpenAiResponsesToolChoice4? OpenAiResponsesToolChoice4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAiResponsesToolChoice4))]
#endif
        public bool IsOpenAiResponsesToolChoice4 => OpenAiResponsesToolChoice4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice0 value) => new OpenAIResponsesToolChoice((global::G.OpenAiResponsesToolChoice0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoice0?(OpenAIResponsesToolChoice @this) => @this.OpenAiResponsesToolChoice0;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice0? value)
        {
            OpenAiResponsesToolChoice0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice1 value) => new OpenAIResponsesToolChoice((global::G.OpenAiResponsesToolChoice1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoice1?(OpenAIResponsesToolChoice @this) => @this.OpenAiResponsesToolChoice1;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice1? value)
        {
            OpenAiResponsesToolChoice1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice2 value) => new OpenAIResponsesToolChoice((global::G.OpenAiResponsesToolChoice2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoice2?(OpenAIResponsesToolChoice @this) => @this.OpenAiResponsesToolChoice2;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice2? value)
        {
            OpenAiResponsesToolChoice2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice3 value) => new OpenAIResponsesToolChoice((global::G.OpenAiResponsesToolChoice3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoice3?(OpenAIResponsesToolChoice @this) => @this.OpenAiResponsesToolChoice3;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice3? value)
        {
            OpenAiResponsesToolChoice3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice4 value) => new OpenAIResponsesToolChoice((global::G.OpenAiResponsesToolChoice4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiResponsesToolChoice4?(OpenAIResponsesToolChoice @this) => @this.OpenAiResponsesToolChoice4;

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(global::G.OpenAiResponsesToolChoice4? value)
        {
            OpenAiResponsesToolChoice4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAIResponsesToolChoice(
            global::G.OpenAiResponsesToolChoice0? openAiResponsesToolChoice0,
            global::G.OpenAiResponsesToolChoice1? openAiResponsesToolChoice1,
            global::G.OpenAiResponsesToolChoice2? openAiResponsesToolChoice2,
            global::G.OpenAiResponsesToolChoice3? openAiResponsesToolChoice3,
            global::G.OpenAiResponsesToolChoice4? openAiResponsesToolChoice4
            )
        {
            OpenAiResponsesToolChoice0 = openAiResponsesToolChoice0;
            OpenAiResponsesToolChoice1 = openAiResponsesToolChoice1;
            OpenAiResponsesToolChoice2 = openAiResponsesToolChoice2;
            OpenAiResponsesToolChoice3 = openAiResponsesToolChoice3;
            OpenAiResponsesToolChoice4 = openAiResponsesToolChoice4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OpenAiResponsesToolChoice4 as object ??
            OpenAiResponsesToolChoice3 as object ??
            OpenAiResponsesToolChoice2 as object ??
            OpenAiResponsesToolChoice1 as object ??
            OpenAiResponsesToolChoice0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAiResponsesToolChoice0?.ToValueString() ??
            OpenAiResponsesToolChoice1?.ToValueString() ??
            OpenAiResponsesToolChoice2?.ToValueString() ??
            OpenAiResponsesToolChoice3?.ToString() ??
            OpenAiResponsesToolChoice4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAiResponsesToolChoice0 && !IsOpenAiResponsesToolChoice1 && !IsOpenAiResponsesToolChoice2 && !IsOpenAiResponsesToolChoice3 && !IsOpenAiResponsesToolChoice4 || !IsOpenAiResponsesToolChoice0 && IsOpenAiResponsesToolChoice1 && !IsOpenAiResponsesToolChoice2 && !IsOpenAiResponsesToolChoice3 && !IsOpenAiResponsesToolChoice4 || !IsOpenAiResponsesToolChoice0 && !IsOpenAiResponsesToolChoice1 && IsOpenAiResponsesToolChoice2 && !IsOpenAiResponsesToolChoice3 && !IsOpenAiResponsesToolChoice4 || !IsOpenAiResponsesToolChoice0 && !IsOpenAiResponsesToolChoice1 && !IsOpenAiResponsesToolChoice2 && IsOpenAiResponsesToolChoice3 && !IsOpenAiResponsesToolChoice4 || !IsOpenAiResponsesToolChoice0 && !IsOpenAiResponsesToolChoice1 && !IsOpenAiResponsesToolChoice2 && !IsOpenAiResponsesToolChoice3 && IsOpenAiResponsesToolChoice4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAiResponsesToolChoice0?, TResult>? openAiResponsesToolChoice0 = null,
            global::System.Func<global::G.OpenAiResponsesToolChoice1?, TResult>? openAiResponsesToolChoice1 = null,
            global::System.Func<global::G.OpenAiResponsesToolChoice2?, TResult>? openAiResponsesToolChoice2 = null,
            global::System.Func<global::G.OpenAiResponsesToolChoice3?, TResult>? openAiResponsesToolChoice3 = null,
            global::System.Func<global::G.OpenAiResponsesToolChoice4?, TResult>? openAiResponsesToolChoice4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponsesToolChoice0 && openAiResponsesToolChoice0 != null)
            {
                return openAiResponsesToolChoice0(OpenAiResponsesToolChoice0!);
            }
            else if (IsOpenAiResponsesToolChoice1 && openAiResponsesToolChoice1 != null)
            {
                return openAiResponsesToolChoice1(OpenAiResponsesToolChoice1!);
            }
            else if (IsOpenAiResponsesToolChoice2 && openAiResponsesToolChoice2 != null)
            {
                return openAiResponsesToolChoice2(OpenAiResponsesToolChoice2!);
            }
            else if (IsOpenAiResponsesToolChoice3 && openAiResponsesToolChoice3 != null)
            {
                return openAiResponsesToolChoice3(OpenAiResponsesToolChoice3!);
            }
            else if (IsOpenAiResponsesToolChoice4 && openAiResponsesToolChoice4 != null)
            {
                return openAiResponsesToolChoice4(OpenAiResponsesToolChoice4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAiResponsesToolChoice0?>? openAiResponsesToolChoice0 = null,
            global::System.Action<global::G.OpenAiResponsesToolChoice1?>? openAiResponsesToolChoice1 = null,
            global::System.Action<global::G.OpenAiResponsesToolChoice2?>? openAiResponsesToolChoice2 = null,
            global::System.Action<global::G.OpenAiResponsesToolChoice3?>? openAiResponsesToolChoice3 = null,
            global::System.Action<global::G.OpenAiResponsesToolChoice4?>? openAiResponsesToolChoice4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAiResponsesToolChoice0)
            {
                openAiResponsesToolChoice0?.Invoke(OpenAiResponsesToolChoice0!);
            }
            else if (IsOpenAiResponsesToolChoice1)
            {
                openAiResponsesToolChoice1?.Invoke(OpenAiResponsesToolChoice1!);
            }
            else if (IsOpenAiResponsesToolChoice2)
            {
                openAiResponsesToolChoice2?.Invoke(OpenAiResponsesToolChoice2!);
            }
            else if (IsOpenAiResponsesToolChoice3)
            {
                openAiResponsesToolChoice3?.Invoke(OpenAiResponsesToolChoice3!);
            }
            else if (IsOpenAiResponsesToolChoice4)
            {
                openAiResponsesToolChoice4?.Invoke(OpenAiResponsesToolChoice4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAiResponsesToolChoice0,
                typeof(global::G.OpenAiResponsesToolChoice0),
                OpenAiResponsesToolChoice1,
                typeof(global::G.OpenAiResponsesToolChoice1),
                OpenAiResponsesToolChoice2,
                typeof(global::G.OpenAiResponsesToolChoice2),
                OpenAiResponsesToolChoice3,
                typeof(global::G.OpenAiResponsesToolChoice3),
                OpenAiResponsesToolChoice4,
                typeof(global::G.OpenAiResponsesToolChoice4),
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
        public bool Equals(OpenAIResponsesToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoice0?>.Default.Equals(OpenAiResponsesToolChoice0, other.OpenAiResponsesToolChoice0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoice1?>.Default.Equals(OpenAiResponsesToolChoice1, other.OpenAiResponsesToolChoice1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoice2?>.Default.Equals(OpenAiResponsesToolChoice2, other.OpenAiResponsesToolChoice2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoice3?>.Default.Equals(OpenAiResponsesToolChoice3, other.OpenAiResponsesToolChoice3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiResponsesToolChoice4?>.Default.Equals(OpenAiResponsesToolChoice4, other.OpenAiResponsesToolChoice4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAIResponsesToolChoice obj1, OpenAIResponsesToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAIResponsesToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAIResponsesToolChoice obj1, OpenAIResponsesToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIResponsesToolChoice o && Equals(o);
        }
    }
}
