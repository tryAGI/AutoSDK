//HintName: G.Models.InvokeParent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Options for tracing the function call
    /// </summary>
    public readonly partial struct InvokeParent : global::System.IEquatable<InvokeParent>
    {
        /// <summary>
        /// Span parent properties
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InvokeParentSpanParentStruct? SpanParentStruct { get; init; }
#else
        public global::G.InvokeParentSpanParentStruct? SpanParentStruct { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpanParentStruct))]
#endif
        public bool IsSpanParentStruct => SpanParentStruct != null;

        /// <summary>
        /// The parent's span identifier, created by calling `.export()` on a span
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvokeParent(global::G.InvokeParentSpanParentStruct value) => new InvokeParent((global::G.InvokeParentSpanParentStruct?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InvokeParentSpanParentStruct?(InvokeParent @this) => @this.SpanParentStruct;

        /// <summary>
        /// 
        /// </summary>
        public InvokeParent(global::G.InvokeParentSpanParentStruct? value)
        {
            SpanParentStruct = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InvokeParent(string value) => new InvokeParent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InvokeParent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public InvokeParent(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InvokeParent(
            global::G.InvokeParentSpanParentStruct? spanParentStruct,
            string? value2
            )
        {
            SpanParentStruct = spanParentStruct;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            SpanParentStruct as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SpanParentStruct?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSpanParentStruct || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InvokeParentSpanParentStruct?, TResult>? spanParentStruct = null,
            global::System.Func<string?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpanParentStruct && spanParentStruct != null)
            {
                return spanParentStruct(SpanParentStruct!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InvokeParentSpanParentStruct?>? spanParentStruct = null,
            global::System.Action<string?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSpanParentStruct)
            {
                spanParentStruct?.Invoke(SpanParentStruct!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpanParentStruct,
                typeof(global::G.InvokeParentSpanParentStruct),
                Value2,
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
        public bool Equals(InvokeParent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InvokeParentSpanParentStruct?>.Default.Equals(SpanParentStruct, other.SpanParentStruct) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InvokeParent obj1, InvokeParent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InvokeParent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InvokeParent obj1, InvokeParent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InvokeParent o && Equals(o);
        }
    }
}
