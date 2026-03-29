//HintName: G.Models.InputsOneOf1ItemsOneOf5Content.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputsOneOf1ItemsOneOf5Content : global::System.IEquatable<InputsOneOf1ItemsOneOf5Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>? InputsOneOf1ItemsOneOf5Content0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>? InputsOneOf1ItemsOneOf5Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf5Content0))]
#endif
        public bool IsInputsOneOf1ItemsOneOf5Content0 => InputsOneOf1ItemsOneOf5Content0 != null;

        /// <summary>
        /// 
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
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1ItemsOneOf5Content(string value) => new InputsOneOf1ItemsOneOf5Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InputsOneOf1ItemsOneOf5Content @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5Content(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5Content(
            global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>? inputsOneOf1ItemsOneOf5Content0,
            string? value2,
            object? value3
            )
        {
            InputsOneOf1ItemsOneOf5Content0 = inputsOneOf1ItemsOneOf5Content0;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            InputsOneOf1ItemsOneOf5Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputsOneOf1ItemsOneOf5Content0?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputsOneOf1ItemsOneOf5Content0 && !IsValue2 && !IsValue3 || !IsInputsOneOf1ItemsOneOf5Content0 && IsValue2 && !IsValue3 || !IsInputsOneOf1ItemsOneOf5Content0 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>?, TResult>? inputsOneOf1ItemsOneOf5Content0 = null,
            global::System.Func<string?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsOneOf1ItemsOneOf5Content0 && inputsOneOf1ItemsOneOf5Content0 != null)
            {
                return inputsOneOf1ItemsOneOf5Content0(InputsOneOf1ItemsOneOf5Content0!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>?>? inputsOneOf1ItemsOneOf5Content0 = null,
            global::System.Action<string?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsOneOf1ItemsOneOf5Content0)
            {
                inputsOneOf1ItemsOneOf5Content0?.Invoke(InputsOneOf1ItemsOneOf5Content0!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputsOneOf1ItemsOneOf5Content0,
                typeof(global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>),
                Value2,
                typeof(string),
                Value3,
                typeof(object),
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
        public bool Equals(InputsOneOf1ItemsOneOf5Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>?>.Default.Equals(InputsOneOf1ItemsOneOf5Content0, other.InputsOneOf1ItemsOneOf5Content0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputsOneOf1ItemsOneOf5Content obj1, InputsOneOf1ItemsOneOf5Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputsOneOf1ItemsOneOf5Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputsOneOf1ItemsOneOf5Content obj1, InputsOneOf1ItemsOneOf5Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputsOneOf1ItemsOneOf5Content o && Equals(o);
        }
    }
}
