//HintName: G.Models.ExtendedPointId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Type, used for specifying point ID in user interface
    /// </summary>
    public readonly partial struct ExtendedPointId : global::System.IEquatable<ExtendedPointId>
    {
        /// <summary>
        /// Example: 42
        /// </summary>
#if NET6_0_OR_GREATER
        public int? ExtendedPointIdVariant1 { get; init; }
#else
        public int? ExtendedPointIdVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtendedPointIdVariant1))]
#endif
        public bool IsExtendedPointIdVariant1 => ExtendedPointIdVariant1 != null;

        /// <summary>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Guid { get; init; }
#else
        public global::System.Guid? Guid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Guid))]
#endif
        public bool IsGuid => Guid != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtendedPointId(int value) => new ExtendedPointId((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(ExtendedPointId @this) => @this.ExtendedPointIdVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(int? value)
        {
            ExtendedPointIdVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtendedPointId(global::System.Guid value) => new ExtendedPointId((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(ExtendedPointId @this) => @this.Guid;

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(global::System.Guid? value)
        {
            Guid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(
            int? extendedPointIdVariant1,
            global::System.Guid? guid
            )
        {
            ExtendedPointIdVariant1 = extendedPointIdVariant1;
            Guid = guid;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Guid as object ??
            ExtendedPointIdVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExtendedPointIdVariant1?.ToString() ??
            Guid?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExtendedPointIdVariant1 || IsGuid;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<int?, TResult>? extendedPointIdVariant1 = null,
            global::System.Func<global::System.Guid?, TResult>? guid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExtendedPointIdVariant1 && extendedPointIdVariant1 != null)
            {
                return extendedPointIdVariant1(ExtendedPointIdVariant1!);
            }
            else if (IsGuid && guid != null)
            {
                return guid(Guid!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<int?>? extendedPointIdVariant1 = null,
            global::System.Action<global::System.Guid?>? guid = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExtendedPointIdVariant1)
            {
                extendedPointIdVariant1?.Invoke(ExtendedPointIdVariant1!);
            }
            else if (IsGuid)
            {
                guid?.Invoke(Guid!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExtendedPointIdVariant1,
                typeof(int),
                Guid,
                typeof(global::System.Guid),
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
        public bool Equals(ExtendedPointId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(ExtendedPointIdVariant1, other.ExtendedPointIdVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Guid, other.Guid) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExtendedPointId obj1, ExtendedPointId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExtendedPointId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExtendedPointId obj1, ExtendedPointId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtendedPointId o && Equals(o);
        }
    }
}
