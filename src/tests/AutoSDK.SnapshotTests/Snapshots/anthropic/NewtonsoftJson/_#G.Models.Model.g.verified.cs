//HintName: G.Models.Model.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The model that will complete your prompt.\n\nSee [models](https://docs.anthropic.com/en/docs/models-overview) for additional details and options.
    /// </summary>
    public readonly partial struct Model : global::System.IEquatable<Model>
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
        public static implicit operator Model(string value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Model @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Model(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelEnum? Value2 { get; init; }
#else
        public global::G.ModelEnum? Value2 { get; }
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
        public static implicit operator Model(global::G.ModelEnum value) => new Model(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelEnum?(Model @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Model(global::G.ModelEnum? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Model(
            string? value1,
            global::G.ModelEnum? value2
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
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<global::G.ModelEnum?, TResult>? value2 = null,
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
            global::System.Action<global::G.ModelEnum?>? value2 = null,
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
                typeof(global::G.ModelEnum),
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
        public bool Equals(Model other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelEnum?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Model obj1, Model obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Model>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Model obj1, Model obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Model o && Equals(o);
        }
    }
}
