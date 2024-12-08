//HintName: G.Models.Delta2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Delta2 : global::System.IEquatable<Delta2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ContentBlockDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContentBlockDelta? TextDelta { get; init; }
#else
        public global::G.TextContentBlockDelta? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.TextContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContentBlockDelta?(Delta2 @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.TextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InputJsonContentBlockDelta? InputJsonDelta { get; init; }
#else
        public global::G.InputJsonContentBlockDelta? InputJsonDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJsonDelta))]
#endif
        public bool IsInputJsonDelta => InputJsonDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::G.InputJsonContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputJsonContentBlockDelta?(Delta2 @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::G.InputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta2(
            global::G.ContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::G.TextContentBlockDelta? textDelta,
            global::G.InputJsonContentBlockDelta? inputJsonDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta || !IsTextDelta && IsInputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::G.InputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsInputJsonDelta && inputJsonDelta != null)
            {
                return inputJsonDelta(InputJsonDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::G.InputJsonContentBlockDelta?>? inputJsonDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsInputJsonDelta)
            {
                inputJsonDelta?.Invoke(InputJsonDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextDelta,
                typeof(global::G.TextContentBlockDelta),
                InputJsonDelta,
                typeof(global::G.InputJsonContentBlockDelta),
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
        public bool Equals(Delta2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContentBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Delta2 obj1, Delta2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Delta2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Delta2 obj1, Delta2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Delta2 o && Equals(o);
        }
    }
}
