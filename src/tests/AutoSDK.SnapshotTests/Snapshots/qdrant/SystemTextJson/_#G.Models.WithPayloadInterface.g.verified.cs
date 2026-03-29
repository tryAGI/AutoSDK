//HintName: G.Models.WithPayloadInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Options for specifying which payload to include or not
    /// </summary>
    public readonly partial struct WithPayloadInterface : global::System.IEquatable<WithPayloadInterface>
    {
        /// <summary>
        /// If `true` - return all payload, If `false` - do not return payload
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value1 { get; init; }
#else
        public bool? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Specify which fields to return
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Specifies how to treat payload selector
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSelector? Value3 { get; init; }
#else
        public global::G.PayloadSelector? Value3 { get; }
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
        public static implicit operator WithPayloadInterface(bool value) => new WithPayloadInterface((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(WithPayloadInterface @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(bool? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WithPayloadInterface(global::G.PayloadSelector value) => new WithPayloadInterface((global::G.PayloadSelector?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSelector?(WithPayloadInterface @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(global::G.PayloadSelector? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WithPayloadInterface(
            bool? value1,
            global::System.Collections.Generic.IList<string>? value2,
            global::G.PayloadSelector? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString().ToLowerInvariant() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<bool?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value2 = null,
            global::System.Func<global::G.PayloadSelector?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<bool?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value2 = null,
            global::System.Action<global::G.PayloadSelector?>? value3 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(bool),
                Value2,
                typeof(global::System.Collections.Generic.IList<string>),
                Value3,
                typeof(global::G.PayloadSelector),
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
        public bool Equals(WithPayloadInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSelector?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WithPayloadInterface obj1, WithPayloadInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WithPayloadInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WithPayloadInterface obj1, WithPayloadInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WithPayloadInterface o && Equals(o);
        }
    }
}
