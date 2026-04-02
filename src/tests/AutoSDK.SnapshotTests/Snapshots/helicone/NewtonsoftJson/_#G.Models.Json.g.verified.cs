//HintName: G.Models.Json.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Json : global::System.IEquatable<Json>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonVariant1 { get; init; }
#else
        public string? JsonVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVariant1))]
#endif
        public bool IsJsonVariant1 => JsonVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? JsonVariant2 { get; init; }
#else
        public double? JsonVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVariant2))]
#endif
        public bool IsJsonVariant2 => JsonVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? JsonVariant3 { get; init; }
#else
        public bool? JsonVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVariant3))]
#endif
        public bool IsJsonVariant3 => JsonVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.Json?>? JsonVariant4 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.Json?>? JsonVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVariant4))]
#endif
        public bool IsJsonVariant4 => JsonVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.Json>? JsonVariant5 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.Json>? JsonVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVariant5))]
#endif
        public bool IsJsonVariant5 => JsonVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Json(string value) => new Json((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Json @this) => @this.JsonVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Json(string? value)
        {
            JsonVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Json(double value) => new Json((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(Json @this) => @this.JsonVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Json(double? value)
        {
            JsonVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Json(bool value) => new Json((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(Json @this) => @this.JsonVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Json(bool? value)
        {
            JsonVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Json(global::System.Collections.Generic.Dictionary<string, global::G.Json?> value) => new Json((global::System.Collections.Generic.Dictionary<string, global::G.Json?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.Json?>?(Json @this) => @this.JsonVariant4;

        /// <summary>
        /// 
        /// </summary>
        public Json(global::System.Collections.Generic.Dictionary<string, global::G.Json?>? value)
        {
            JsonVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Json(
            string? jsonVariant1,
            double? jsonVariant2,
            bool? jsonVariant3,
            global::System.Collections.Generic.Dictionary<string, global::G.Json?>? jsonVariant4,
            global::System.Collections.Generic.IList<global::G.Json>? jsonVariant5
            )
        {
            JsonVariant1 = jsonVariant1;
            JsonVariant2 = jsonVariant2;
            JsonVariant3 = jsonVariant3;
            JsonVariant4 = jsonVariant4;
            JsonVariant5 = jsonVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonVariant5 as object ??
            JsonVariant4 as object ??
            JsonVariant3 as object ??
            JsonVariant2 as object ??
            JsonVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonVariant1?.ToString() ??
            JsonVariant2?.ToString() ??
            JsonVariant3?.ToString().ToLowerInvariant() ??
            JsonVariant4?.ToString() ??
            JsonVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonVariant1 || IsJsonVariant2 || IsJsonVariant3 || IsJsonVariant4 || IsJsonVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? jsonVariant1 = null,
            global::System.Func<double?, TResult>? jsonVariant2 = null,
            global::System.Func<bool?, TResult>? jsonVariant3 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.Json?>?, TResult>? jsonVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.Json>?, TResult>? jsonVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonVariant1 && jsonVariant1 != null)
            {
                return jsonVariant1(JsonVariant1!);
            }
            else if (IsJsonVariant2 && jsonVariant2 != null)
            {
                return jsonVariant2(JsonVariant2!);
            }
            else if (IsJsonVariant3 && jsonVariant3 != null)
            {
                return jsonVariant3(JsonVariant3!);
            }
            else if (IsJsonVariant4 && jsonVariant4 != null)
            {
                return jsonVariant4(JsonVariant4!);
            }
            else if (IsJsonVariant5 && jsonVariant5 != null)
            {
                return jsonVariant5(JsonVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? jsonVariant1 = null,
            global::System.Action<double?>? jsonVariant2 = null,
            global::System.Action<bool?>? jsonVariant3 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.Json?>?>? jsonVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.Json>?>? jsonVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonVariant1)
            {
                jsonVariant1?.Invoke(JsonVariant1!);
            }
            else if (IsJsonVariant2)
            {
                jsonVariant2?.Invoke(JsonVariant2!);
            }
            else if (IsJsonVariant3)
            {
                jsonVariant3?.Invoke(JsonVariant3!);
            }
            else if (IsJsonVariant4)
            {
                jsonVariant4?.Invoke(JsonVariant4!);
            }
            else if (IsJsonVariant5)
            {
                jsonVariant5?.Invoke(JsonVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonVariant1,
                typeof(string),
                JsonVariant2,
                typeof(double),
                JsonVariant3,
                typeof(bool),
                JsonVariant4,
                typeof(global::System.Collections.Generic.Dictionary<string, global::G.Json?>),
                JsonVariant5,
                typeof(global::System.Collections.Generic.IList<global::G.Json>),
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
        public bool Equals(Json other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonVariant1, other.JsonVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(JsonVariant2, other.JsonVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(JsonVariant3, other.JsonVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.Json?>?>.Default.Equals(JsonVariant4, other.JsonVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.Json>?>.Default.Equals(JsonVariant5, other.JsonVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Json obj1, Json obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Json>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Json obj1, Json obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Json o && Equals(o);
        }
    }
}
