//HintName: G.Models.Container.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The code interpreter container. Can be a container ID or an object that<br/>
    /// specifies uploaded file IDs to make available to your code.
    /// </summary>
    public readonly partial struct Container : global::System.IEquatable<Container>
    {
        /// <summary>
        /// The container ID.
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
        /// Configuration for a code interpreter container. Optionally specify the IDs<br/>
        /// of the files to run the code on.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CodeInterpreterToolAuto? Auto { get; init; }
#else
        public global::G.CodeInterpreterToolAuto? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Container(string value) => new Container((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Container @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Container(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Container(global::G.CodeInterpreterToolAuto value) => new Container((global::G.CodeInterpreterToolAuto?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CodeInterpreterToolAuto?(Container @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public Container(global::G.CodeInterpreterToolAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Container(
            string? value1,
            global::G.CodeInterpreterToolAuto? auto
            )
        {
            Value1 = value1;
            Auto = auto;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Auto as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Auto?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsAuto || !IsValue1 && IsAuto;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::G.CodeInterpreterToolAuto?, TResult>? auto = null,
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
            else if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::G.CodeInterpreterToolAuto?>? auto = null,
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
            else if (IsAuto)
            {
                auto?.Invoke(Auto!);
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
                Auto,
                typeof(global::G.CodeInterpreterToolAuto),
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
        public bool Equals(Container other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CodeInterpreterToolAuto?>.Default.Equals(Auto, other.Auto) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Container obj1, Container obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Container>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Container obj1, Container obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Container o && Equals(o);
        }
    }
}
