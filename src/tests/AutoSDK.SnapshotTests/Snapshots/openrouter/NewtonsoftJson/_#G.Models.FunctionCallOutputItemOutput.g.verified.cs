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
        public string? FunctionCallOutputItemOutputVariant1 { get; init; }
#else
        public string? FunctionCallOutputItemOutputVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItemOutputVariant1))]
#endif
        public bool IsFunctionCallOutputItemOutputVariant1 => FunctionCallOutputItemOutputVariant1 != null;

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
        public static implicit operator string?(FunctionCallOutputItemOutput @this) => @this.FunctionCallOutputItemOutputVariant1;

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutput(string? value)
        {
            FunctionCallOutputItemOutputVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FunctionCallOutputItemOutput(
            string? functionCallOutputItemOutputVariant1,
            global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>? functionCallOutputItemOutput1
            )
        {
            FunctionCallOutputItemOutputVariant1 = functionCallOutputItemOutputVariant1;
            FunctionCallOutputItemOutput1 = functionCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FunctionCallOutputItemOutput1 as object ??
            FunctionCallOutputItemOutputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FunctionCallOutputItemOutputVariant1?.ToString() ??
            FunctionCallOutputItemOutput1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunctionCallOutputItemOutputVariant1 && !IsFunctionCallOutputItemOutput1 || !IsFunctionCallOutputItemOutputVariant1 && IsFunctionCallOutputItemOutput1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? functionCallOutputItemOutputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>?, TResult>? functionCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputItemOutputVariant1 && functionCallOutputItemOutputVariant1 != null)
            {
                return functionCallOutputItemOutputVariant1(FunctionCallOutputItemOutputVariant1!);
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
            global::System.Action<string?>? functionCallOutputItemOutputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.FunctionCallOutputItemOutputOneOf1Items>?>? functionCallOutputItemOutput1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunctionCallOutputItemOutputVariant1)
            {
                functionCallOutputItemOutputVariant1?.Invoke(FunctionCallOutputItemOutputVariant1!);
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
                FunctionCallOutputItemOutputVariant1,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(FunctionCallOutputItemOutputVariant1, other.FunctionCallOutputItemOutputVariant1) &&
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
