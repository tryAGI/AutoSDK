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
        public string? InputsOneOf1ItemsOneOf5ContentVariant2 { get; init; }
#else
        public string? InputsOneOf1ItemsOneOf5ContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf5ContentVariant2))]
#endif
        public bool IsInputsOneOf1ItemsOneOf5ContentVariant2 => InputsOneOf1ItemsOneOf5ContentVariant2 != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? InputsOneOf1ItemsOneOf5ContentVariant3 { get; init; }
#else
        public object? InputsOneOf1ItemsOneOf5ContentVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf5ContentVariant3))]
#endif
        public bool IsInputsOneOf1ItemsOneOf5ContentVariant3 => InputsOneOf1ItemsOneOf5ContentVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1ItemsOneOf5Content(string value) => new InputsOneOf1ItemsOneOf5Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InputsOneOf1ItemsOneOf5Content @this) => @this.InputsOneOf1ItemsOneOf5ContentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5Content(string? value)
        {
            InputsOneOf1ItemsOneOf5ContentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf5Content(
            global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>? inputsOneOf1ItemsOneOf5Content0,
            string? inputsOneOf1ItemsOneOf5ContentVariant2,
            object? inputsOneOf1ItemsOneOf5ContentVariant3
            )
        {
            InputsOneOf1ItemsOneOf5Content0 = inputsOneOf1ItemsOneOf5Content0;
            InputsOneOf1ItemsOneOf5ContentVariant2 = inputsOneOf1ItemsOneOf5ContentVariant2;
            InputsOneOf1ItemsOneOf5ContentVariant3 = inputsOneOf1ItemsOneOf5ContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputsOneOf1ItemsOneOf5ContentVariant3 as object ??
            InputsOneOf1ItemsOneOf5ContentVariant2 as object ??
            InputsOneOf1ItemsOneOf5Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputsOneOf1ItemsOneOf5Content0?.ToString() ??
            InputsOneOf1ItemsOneOf5ContentVariant2?.ToString() ??
            InputsOneOf1ItemsOneOf5ContentVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputsOneOf1ItemsOneOf5Content0 && !IsInputsOneOf1ItemsOneOf5ContentVariant2 && !IsInputsOneOf1ItemsOneOf5ContentVariant3 || !IsInputsOneOf1ItemsOneOf5Content0 && IsInputsOneOf1ItemsOneOf5ContentVariant2 && !IsInputsOneOf1ItemsOneOf5ContentVariant3 || !IsInputsOneOf1ItemsOneOf5Content0 && !IsInputsOneOf1ItemsOneOf5ContentVariant2 && IsInputsOneOf1ItemsOneOf5ContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>?, TResult>? inputsOneOf1ItemsOneOf5Content0 = null,
            global::System.Func<string?, TResult>? inputsOneOf1ItemsOneOf5ContentVariant2 = null,
            global::System.Func<object?, TResult>? inputsOneOf1ItemsOneOf5ContentVariant3 = null,
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
            else if (IsInputsOneOf1ItemsOneOf5ContentVariant2 && inputsOneOf1ItemsOneOf5ContentVariant2 != null)
            {
                return inputsOneOf1ItemsOneOf5ContentVariant2(InputsOneOf1ItemsOneOf5ContentVariant2!);
            }
            else if (IsInputsOneOf1ItemsOneOf5ContentVariant3 && inputsOneOf1ItemsOneOf5ContentVariant3 != null)
            {
                return inputsOneOf1ItemsOneOf5ContentVariant3(InputsOneOf1ItemsOneOf5ContentVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>?>? inputsOneOf1ItemsOneOf5Content0 = null,
            global::System.Action<string?>? inputsOneOf1ItemsOneOf5ContentVariant2 = null,
            global::System.Action<object?>? inputsOneOf1ItemsOneOf5ContentVariant3 = null,
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
            else if (IsInputsOneOf1ItemsOneOf5ContentVariant2)
            {
                inputsOneOf1ItemsOneOf5ContentVariant2?.Invoke(InputsOneOf1ItemsOneOf5ContentVariant2!);
            }
            else if (IsInputsOneOf1ItemsOneOf5ContentVariant3)
            {
                inputsOneOf1ItemsOneOf5ContentVariant3?.Invoke(InputsOneOf1ItemsOneOf5ContentVariant3!);
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
                InputsOneOf1ItemsOneOf5ContentVariant2,
                typeof(string),
                InputsOneOf1ItemsOneOf5ContentVariant3,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputsOneOf1ItemsOneOf5ContentVariant2, other.InputsOneOf1ItemsOneOf5ContentVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(InputsOneOf1ItemsOneOf5ContentVariant3, other.InputsOneOf1ItemsOneOf5ContentVariant3) 
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
