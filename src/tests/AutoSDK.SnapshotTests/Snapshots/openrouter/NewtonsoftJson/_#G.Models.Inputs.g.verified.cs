//HintName: G.Models.Inputs.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Input for a response request - can be a string or array of items
    /// </summary>
    public readonly partial struct Inputs : global::System.IEquatable<Inputs>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InputsVariant1 { get; init; }
#else
        public string? InputsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsVariant1))]
#endif
        public bool IsInputsVariant1 => InputsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>? Inputs1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>? Inputs1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inputs1))]
#endif
        public bool IsInputs1 => Inputs1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Inputs(string value) => new Inputs((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Inputs @this) => @this.InputsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Inputs(string? value)
        {
            InputsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Inputs(
            string? inputsVariant1,
            global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>? inputs1
            )
        {
            InputsVariant1 = inputsVariant1;
            Inputs1 = inputs1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Inputs1 as object ??
            InputsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputsVariant1?.ToString() ??
            Inputs1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputsVariant1 && !IsInputs1 || !IsInputsVariant1 && IsInputs1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? inputsVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>?, TResult>? inputs1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsVariant1 && inputsVariant1 != null)
            {
                return inputsVariant1(InputsVariant1!);
            }
            else if (IsInputs1 && inputs1 != null)
            {
                return inputs1(Inputs1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? inputsVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>?>? inputs1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsVariant1)
            {
                inputsVariant1?.Invoke(InputsVariant1!);
            }
            else if (IsInputs1)
            {
                inputs1?.Invoke(Inputs1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputsVariant1,
                typeof(string),
                Inputs1,
                typeof(global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>),
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
        public bool Equals(Inputs other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputsVariant1, other.InputsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.InputsOneOf1Items>?>.Default.Equals(Inputs1, other.Inputs1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Inputs obj1, Inputs obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Inputs>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Inputs obj1, Inputs obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Inputs o && Equals(o);
        }
    }
}
