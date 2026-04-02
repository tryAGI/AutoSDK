//HintName: G.Models.MapValue.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MapValue : global::System.IEquatable<MapValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MapValueVariant1 { get; init; }
#else
        public string? MapValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapValueVariant1))]
#endif
        public bool IsMapValueVariant1 => MapValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? MapValueVariant2 { get; init; }
#else
        public int? MapValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapValueVariant2))]
#endif
        public bool IsMapValueVariant2 => MapValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public int? MapValueVariant3 { get; init; }
#else
        public int? MapValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapValueVariant3))]
#endif
        public bool IsMapValueVariant3 => MapValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? MapValueVariant4 { get; init; }
#else
        public bool? MapValueVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapValueVariant4))]
#endif
        public bool IsMapValueVariant4 => MapValueVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? MapValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? MapValueVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapValueVariant5))]
#endif
        public bool IsMapValueVariant5 => MapValueVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MapValue(string value) => new MapValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MapValue @this) => @this.MapValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public MapValue(string? value)
        {
            MapValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MapValue(int value) => new MapValue((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(MapValue @this) => @this.MapValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MapValue(int? value)
        {
            MapValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MapValue(bool value) => new MapValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(MapValue @this) => @this.MapValueVariant4;

        /// <summary>
        /// 
        /// </summary>
        public MapValue(bool? value)
        {
            MapValueVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MapValue(
            string? mapValueVariant1,
            int? mapValueVariant2,
            int? mapValueVariant3,
            bool? mapValueVariant4,
            global::System.Collections.Generic.IList<string>? mapValueVariant5
            )
        {
            MapValueVariant1 = mapValueVariant1;
            MapValueVariant2 = mapValueVariant2;
            MapValueVariant3 = mapValueVariant3;
            MapValueVariant4 = mapValueVariant4;
            MapValueVariant5 = mapValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MapValueVariant5 as object ??
            MapValueVariant4 as object ??
            MapValueVariant3 as object ??
            MapValueVariant2 as object ??
            MapValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MapValueVariant1?.ToString() ??
            MapValueVariant2?.ToString() ??
            MapValueVariant3?.ToString() ??
            MapValueVariant4?.ToString().ToLowerInvariant() ??
            MapValueVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMapValueVariant1 && !IsMapValueVariant2 && !IsMapValueVariant3 && !IsMapValueVariant4 && !IsMapValueVariant5 || !IsMapValueVariant1 && IsMapValueVariant2 && !IsMapValueVariant3 && !IsMapValueVariant4 && !IsMapValueVariant5 || !IsMapValueVariant1 && !IsMapValueVariant2 && IsMapValueVariant3 && !IsMapValueVariant4 && !IsMapValueVariant5 || !IsMapValueVariant1 && !IsMapValueVariant2 && !IsMapValueVariant3 && IsMapValueVariant4 && !IsMapValueVariant5 || !IsMapValueVariant1 && !IsMapValueVariant2 && !IsMapValueVariant3 && !IsMapValueVariant4 && IsMapValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? mapValueVariant1 = null,
            global::System.Func<int?, TResult>? mapValueVariant2 = null,
            global::System.Func<int?, TResult>? mapValueVariant3 = null,
            global::System.Func<bool?, TResult>? mapValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? mapValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMapValueVariant1 && mapValueVariant1 != null)
            {
                return mapValueVariant1(MapValueVariant1!);
            }
            else if (IsMapValueVariant2 && mapValueVariant2 != null)
            {
                return mapValueVariant2(MapValueVariant2!);
            }
            else if (IsMapValueVariant3 && mapValueVariant3 != null)
            {
                return mapValueVariant3(MapValueVariant3!);
            }
            else if (IsMapValueVariant4 && mapValueVariant4 != null)
            {
                return mapValueVariant4(MapValueVariant4!);
            }
            else if (IsMapValueVariant5 && mapValueVariant5 != null)
            {
                return mapValueVariant5(MapValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? mapValueVariant1 = null,
            global::System.Action<int?>? mapValueVariant2 = null,
            global::System.Action<int?>? mapValueVariant3 = null,
            global::System.Action<bool?>? mapValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? mapValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMapValueVariant1)
            {
                mapValueVariant1?.Invoke(MapValueVariant1!);
            }
            else if (IsMapValueVariant2)
            {
                mapValueVariant2?.Invoke(MapValueVariant2!);
            }
            else if (IsMapValueVariant3)
            {
                mapValueVariant3?.Invoke(MapValueVariant3!);
            }
            else if (IsMapValueVariant4)
            {
                mapValueVariant4?.Invoke(MapValueVariant4!);
            }
            else if (IsMapValueVariant5)
            {
                mapValueVariant5?.Invoke(MapValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MapValueVariant1,
                typeof(string),
                MapValueVariant2,
                typeof(int),
                MapValueVariant3,
                typeof(int),
                MapValueVariant4,
                typeof(bool),
                MapValueVariant5,
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
        public bool Equals(MapValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MapValueVariant1, other.MapValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(MapValueVariant2, other.MapValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(MapValueVariant3, other.MapValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(MapValueVariant4, other.MapValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(MapValueVariant5, other.MapValueVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MapValue obj1, MapValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MapValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MapValue obj1, MapValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MapValue o && Equals(o);
        }
    }
}
