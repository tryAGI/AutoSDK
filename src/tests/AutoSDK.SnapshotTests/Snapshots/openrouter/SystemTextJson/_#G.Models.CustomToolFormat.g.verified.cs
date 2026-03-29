//HintName: G.Models.CustomToolFormat.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CustomToolFormat : global::System.IEquatable<CustomToolFormat>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomToolFormat0? CustomToolFormat0 { get; init; }
#else
        public global::G.CustomToolFormat0? CustomToolFormat0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolFormat0))]
#endif
        public bool IsCustomToolFormat0 => CustomToolFormat0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CustomToolFormat1? CustomToolFormat1 { get; init; }
#else
        public global::G.CustomToolFormat1? CustomToolFormat1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolFormat1))]
#endif
        public bool IsCustomToolFormat1 => CustomToolFormat1 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolFormat(global::G.CustomToolFormat0 value) => new CustomToolFormat((global::G.CustomToolFormat0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomToolFormat0?(CustomToolFormat @this) => @this.CustomToolFormat0;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolFormat(global::G.CustomToolFormat0? value)
        {
            CustomToolFormat0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CustomToolFormat(global::G.CustomToolFormat1 value) => new CustomToolFormat((global::G.CustomToolFormat1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CustomToolFormat1?(CustomToolFormat @this) => @this.CustomToolFormat1;

        /// <summary>
        /// 
        /// </summary>
        public CustomToolFormat(global::G.CustomToolFormat1? value)
        {
            CustomToolFormat1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CustomToolFormat(
            global::G.CustomToolFormat0? customToolFormat0,
            global::G.CustomToolFormat1? customToolFormat1
            )
        {
            CustomToolFormat0 = customToolFormat0;
            CustomToolFormat1 = customToolFormat1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CustomToolFormat1 as object ??
            CustomToolFormat0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CustomToolFormat0?.ToString() ??
            CustomToolFormat1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustomToolFormat0 && !IsCustomToolFormat1 || !IsCustomToolFormat0 && IsCustomToolFormat1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CustomToolFormat0?, TResult>? customToolFormat0 = null,
            global::System.Func<global::G.CustomToolFormat1?, TResult>? customToolFormat1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolFormat0 && customToolFormat0 != null)
            {
                return customToolFormat0(CustomToolFormat0!);
            }
            else if (IsCustomToolFormat1 && customToolFormat1 != null)
            {
                return customToolFormat1(CustomToolFormat1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CustomToolFormat0?>? customToolFormat0 = null,
            global::System.Action<global::G.CustomToolFormat1?>? customToolFormat1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustomToolFormat0)
            {
                customToolFormat0?.Invoke(CustomToolFormat0!);
            }
            else if (IsCustomToolFormat1)
            {
                customToolFormat1?.Invoke(CustomToolFormat1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CustomToolFormat0,
                typeof(global::G.CustomToolFormat0),
                CustomToolFormat1,
                typeof(global::G.CustomToolFormat1),
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
        public bool Equals(CustomToolFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CustomToolFormat0?>.Default.Equals(CustomToolFormat0, other.CustomToolFormat0) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CustomToolFormat1?>.Default.Equals(CustomToolFormat1, other.CustomToolFormat1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CustomToolFormat obj1, CustomToolFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomToolFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CustomToolFormat obj1, CustomToolFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolFormat o && Equals(o);
        }
    }
}
