//HintName: G.Models.FunctionCallOutputItemOutput.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FunctionCallOutputItemOutput : global::System.IEquatable<FunctionCallOutputItemOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>? FunctionCallOutputItemOutput1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>? FunctionCallOutputItemOutput1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItemOutput1))]
#endif
        public bool IsFunctionCallOutputItemOutput1 => FunctionCallOutputItemOutput1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FunctionCallOutputItemOutput(string value) => new FunctionCallOutputItemOutput((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FunctionCallOutputItemOutput @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutput(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutput(
            string? value1,
            global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>? functionCallOutputItemOutput1
            )
        {
            Value1 = value1;
            FunctionCallOutputItemOutput1 = functionCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionCallOutputItemOutput1 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            FunctionCallOutputItemOutput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsFunctionCallOutputItemOutput1 || !IsValue1 && IsFunctionCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>?, TResult>? functionCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsFunctionCallOutputItemOutput1 && functionCallOutputItemOutput1 != null)
            {
                return functionCallOutputItemOutput1(FunctionCallOutputItemOutput1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>?>? functionCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsFunctionCallOutputItemOutput1)
            {
                functionCallOutputItemOutput1?.Invoke(FunctionCallOutputItemOutput1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                FunctionCallOutputItemOutput1,
                typeof(global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>),
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
        public bool Equals(FunctionCallOutputItemOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>?>.Default.Equals(FunctionCallOutputItemOutput1, other.FunctionCallOutputItemOutput1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FunctionCallOutputItemOutput obj1, FunctionCallOutputItemOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FunctionCallOutputItemOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FunctionCallOutputItemOutput obj1, FunctionCallOutputItemOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FunctionCallOutputItemOutput o && Equals(o);
        }
    }
}
