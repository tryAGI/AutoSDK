//HintName: G.Models.CollectionTelemetryEnum.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CollectionTelemetryEnum : global::System.IEquatable<CollectionTelemetryEnum>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CollectionTelemetry? Value1 { get; init; }
#else
        public global::G.CollectionTelemetry? Value1 { get; }
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
        public global::G.CollectionsAggregatedTelemetry? Value2 { get; init; }
#else
        public global::G.CollectionsAggregatedTelemetry? Value2 { get; }
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
        public static implicit operator CollectionTelemetryEnum(global::G.CollectionTelemetry value) => new CollectionTelemetryEnum((global::G.CollectionTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionTelemetry?(CollectionTelemetryEnum @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::G.CollectionTelemetry? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CollectionTelemetryEnum(global::G.CollectionsAggregatedTelemetry value) => new CollectionTelemetryEnum((global::G.CollectionsAggregatedTelemetry?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CollectionsAggregatedTelemetry?(CollectionTelemetryEnum @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(global::G.CollectionsAggregatedTelemetry? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CollectionTelemetryEnum(
            global::G.CollectionTelemetry? value1,
            global::G.CollectionsAggregatedTelemetry? value2
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
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CollectionTelemetry?, TResult>? value1 = null,
            global::System.Func<global::G.CollectionsAggregatedTelemetry?, TResult>? value2 = null,
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
            global::System.Action<global::G.CollectionTelemetry?>? value1 = null,
            global::System.Action<global::G.CollectionsAggregatedTelemetry?>? value2 = null,
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
                typeof(global::G.CollectionTelemetry),
                Value2,
                typeof(global::G.CollectionsAggregatedTelemetry),
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
        public bool Equals(CollectionTelemetryEnum other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionTelemetry?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CollectionsAggregatedTelemetry?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CollectionTelemetryEnum>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CollectionTelemetryEnum obj1, CollectionTelemetryEnum obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CollectionTelemetryEnum o && Equals(o);
        }
    }
}
