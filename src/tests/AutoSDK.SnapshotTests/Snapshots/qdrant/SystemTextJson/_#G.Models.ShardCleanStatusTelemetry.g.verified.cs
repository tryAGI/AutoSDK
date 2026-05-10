//HintName: G.Models.ShardCleanStatusTelemetry.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ShardCleanStatusTelemetry : global::System.IEquatable<ShardCleanStatusTelemetry>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShardCleanStatusTelemetryEnum? Enum { get; init; }
#else
        public global::G.ShardCleanStatusTelemetryEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ShardCleanStatusTelemetryEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ShardCleanStatusTelemetryEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShardCleanStatusTelemetryEnum2? Enum2 { get; init; }
#else
        public global::G.ShardCleanStatusTelemetryEnum2? Enum2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum2))]
#endif
        public bool IsEnum2 => Enum2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ShardCleanStatusTelemetryEnum2? value)
        {
            value = Enum2;
            return IsEnum2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ShardCleanStatusTelemetryEnum2 PickEnum2() => IsEnum2
            ? Enum2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ShardCleanStatusTelemetryEnum3? Enum3 { get; init; }
#else
        public global::G.ShardCleanStatusTelemetryEnum3? Enum3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum3))]
#endif
        public bool IsEnum3 => Enum3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnum3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ShardCleanStatusTelemetryEnum3? value)
        {
            value = Enum3;
            return IsEnum3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ShardCleanStatusTelemetryEnum3 PickEnum3() => IsEnum3
            ? Enum3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum value) => new ShardCleanStatusTelemetry((global::G.ShardCleanStatusTelemetryEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShardCleanStatusTelemetryEnum?(ShardCleanStatusTelemetry @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShardCleanStatusTelemetry FromEnum(global::G.ShardCleanStatusTelemetryEnum? value) => new ShardCleanStatusTelemetry(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum2 value) => new ShardCleanStatusTelemetry((global::G.ShardCleanStatusTelemetryEnum2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShardCleanStatusTelemetryEnum2?(ShardCleanStatusTelemetry @this) => @this.Enum2;

        /// <summary>
        /// 
        /// </summary>
        public ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum2? value)
        {
            Enum2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShardCleanStatusTelemetry FromEnum2(global::G.ShardCleanStatusTelemetryEnum2? value) => new ShardCleanStatusTelemetry(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum3 value) => new ShardCleanStatusTelemetry((global::G.ShardCleanStatusTelemetryEnum3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ShardCleanStatusTelemetryEnum3?(ShardCleanStatusTelemetry @this) => @this.Enum3;

        /// <summary>
        /// 
        /// </summary>
        public ShardCleanStatusTelemetry(global::G.ShardCleanStatusTelemetryEnum3? value)
        {
            Enum3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ShardCleanStatusTelemetry FromEnum3(global::G.ShardCleanStatusTelemetryEnum3? value) => new ShardCleanStatusTelemetry(value);

        /// <summary>
        /// 
        /// </summary>
        public ShardCleanStatusTelemetry(
            global::G.ShardCleanStatusTelemetryEnum? @enum,
            global::G.ShardCleanStatusTelemetryEnum2? enum2,
            global::G.ShardCleanStatusTelemetryEnum3? enum3
            )
        {
            Enum = @enum;
            Enum2 = enum2;
            Enum3 = enum3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum3 as object ??
            Enum2 as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Enum2?.ToString() ??
            Enum3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsEnum2 && !IsEnum3 || !IsEnum && IsEnum2 && !IsEnum3 || !IsEnum && !IsEnum2 && IsEnum3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ShardCleanStatusTelemetryEnum?, TResult>? @enum = null,
            global::System.Func<global::G.ShardCleanStatusTelemetryEnum2, TResult>? enum2 = null,
            global::System.Func<global::G.ShardCleanStatusTelemetryEnum3, TResult>? enum3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsEnum2 && enum2 != null)
            {
                return enum2(Enum2!);
            }
            else if (IsEnum3 && enum3 != null)
            {
                return enum3(Enum3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ShardCleanStatusTelemetryEnum?>? @enum = null,

            global::System.Action<global::G.ShardCleanStatusTelemetryEnum2>? enum2 = null,

            global::System.Action<global::G.ShardCleanStatusTelemetryEnum3>? enum3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEnum2)
            {
                enum2?.Invoke(Enum2!);
            }
            else if (IsEnum3)
            {
                enum3?.Invoke(Enum3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ShardCleanStatusTelemetryEnum?>? @enum = null,
            global::System.Action<global::G.ShardCleanStatusTelemetryEnum2>? enum2 = null,
            global::System.Action<global::G.ShardCleanStatusTelemetryEnum3>? enum3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsEnum2)
            {
                enum2?.Invoke(Enum2!);
            }
            else if (IsEnum3)
            {
                enum3?.Invoke(Enum3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.ShardCleanStatusTelemetryEnum),
                Enum2,
                typeof(global::G.ShardCleanStatusTelemetryEnum2),
                Enum3,
                typeof(global::G.ShardCleanStatusTelemetryEnum3),
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
        public bool Equals(ShardCleanStatusTelemetry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ShardCleanStatusTelemetryEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShardCleanStatusTelemetryEnum2?>.Default.Equals(Enum2, other.Enum2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ShardCleanStatusTelemetryEnum3?>.Default.Equals(Enum3, other.Enum3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ShardCleanStatusTelemetry obj1, ShardCleanStatusTelemetry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ShardCleanStatusTelemetry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ShardCleanStatusTelemetry obj1, ShardCleanStatusTelemetry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ShardCleanStatusTelemetry o && Equals(o);
        }
    }
}
