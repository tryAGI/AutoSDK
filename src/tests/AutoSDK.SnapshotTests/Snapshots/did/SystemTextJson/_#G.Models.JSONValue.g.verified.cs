//HintName: G.Models.JSONValue.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JSONValue : global::System.IEquatable<JSONValue>
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
        public double? Value2 { get; init; }
#else
        public double? Value2 { get; }
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
#if NET6_0_OR_GREATER
        public bool? Value3 { get; init; }
#else
        public bool? Value3 { get; }
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
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.JSONValue>? Value4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.JSONValue>? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? Value5 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(string value) => new JSONValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JSONValue @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(double value) => new JSONValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(JSONValue @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(double? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(bool value) => new JSONValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(JSONValue @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(bool? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?> value) => new JSONValue((global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?(JSONValue @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(
            string? value1,
            double? value2,
            bool? value3,
            global::System.Collections.Generic.IList<global::G.JSONValue>? value4,
            global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString().ToLowerInvariant() ??
            Value4?.ToString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<double?, TResult>? value2 = null,
            global::System.Func<bool?, TResult>? value3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.JSONValue>?, TResult>? value4 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?, TResult>? value5 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<double?>? value2 = null,
            global::System.Action<bool?>? value3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.JSONValue>?>? value4 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?>? value5 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
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
                Value2,
                typeof(double),
                Value3,
                typeof(bool),
                Value4,
                typeof(global::System.Collections.Generic.IList<global::G.JSONValue>),
                Value5,
                typeof(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>),
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
        public bool Equals(JSONValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.JSONValue>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?>.Default.Equals(Value5, other.Value5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JSONValue obj1, JSONValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JSONValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JSONValue obj1, JSONValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JSONValue o && Equals(o);
        }
    }
}
