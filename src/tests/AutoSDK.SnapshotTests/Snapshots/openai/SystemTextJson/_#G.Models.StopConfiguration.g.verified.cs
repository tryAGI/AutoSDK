//HintName: G.Models.StopConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Not supported with latest reasoning models `o3` and `o4-mini`.<br/>
    /// Up to 4 sequences where the API will stop generating further tokens. The<br/>
    /// returned text will not contain the stop sequence.
    /// </summary>
    public readonly partial struct StopConfiguration : global::System.IEquatable<StopConfiguration>
    {
        /// <summary>
        /// Default Value: &lt;|endoftext|&gt;
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
        public static implicit operator StopConfiguration(string value) => new StopConfiguration(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StopConfiguration @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public StopConfiguration(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public StopConfiguration(global::System.Collections.Generic.IList<string>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StopConfiguration(
            string? value1,
            global::System.Collections.Generic.IList<string>? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? value2 = null,
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
                typeof(global::System.Collections.Generic.IList<string>),
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
        public bool Equals(StopConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StopConfiguration obj1, StopConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StopConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StopConfiguration obj1, StopConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StopConfiguration o && Equals(o);
        }
    }
}
