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
        public string? JSONValueVariant1 { get; init; }
#else
        public string? JSONValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONValueVariant1))]
#endif
        public bool IsJSONValueVariant1 => JSONValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? JSONValueVariant2 { get; init; }
#else
        public double? JSONValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONValueVariant2))]
#endif
        public bool IsJSONValueVariant2 => JSONValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? JSONValueVariant3 { get; init; }
#else
        public bool? JSONValueVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONValueVariant3))]
#endif
        public bool IsJSONValueVariant3 => JSONValueVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.JSONValue>? JSONValueVariant4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.JSONValue>? JSONValueVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONValueVariant4))]
#endif
        public bool IsJSONValueVariant4 => JSONValueVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? JSONValueVariant5 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? JSONValueVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONValueVariant5))]
#endif
        public bool IsJSONValueVariant5 => JSONValueVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(string value) => new JSONValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JSONValue @this) => @this.JSONValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(string? value)
        {
            JSONValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(double value) => new JSONValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(JSONValue @this) => @this.JSONValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(double? value)
        {
            JSONValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(bool value) => new JSONValue((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(JSONValue @this) => @this.JSONValueVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(bool? value)
        {
            JSONValueVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JSONValue(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?> value) => new JSONValue((global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?(JSONValue @this) => @this.JSONValueVariant5;

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? value)
        {
            JSONValueVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JSONValue(
            string? jSONValueVariant1,
            double? jSONValueVariant2,
            bool? jSONValueVariant3,
            global::System.Collections.Generic.IList<global::G.JSONValue>? jSONValueVariant4,
            global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>? jSONValueVariant5
            )
        {
            JSONValueVariant1 = jSONValueVariant1;
            JSONValueVariant2 = jSONValueVariant2;
            JSONValueVariant3 = jSONValueVariant3;
            JSONValueVariant4 = jSONValueVariant4;
            JSONValueVariant5 = jSONValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JSONValueVariant5 as object ??
            JSONValueVariant4 as object ??
            JSONValueVariant3 as object ??
            JSONValueVariant2 as object ??
            JSONValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JSONValueVariant1?.ToString() ??
            JSONValueVariant2?.ToString() ??
            JSONValueVariant3?.ToString().ToLowerInvariant() ??
            JSONValueVariant4?.ToString() ??
            JSONValueVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJSONValueVariant1 || IsJSONValueVariant2 || IsJSONValueVariant3 || IsJSONValueVariant4 || IsJSONValueVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? jSONValueVariant1 = null,
            global::System.Func<double?, TResult>? jSONValueVariant2 = null,
            global::System.Func<bool?, TResult>? jSONValueVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.JSONValue>?, TResult>? jSONValueVariant4 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?, TResult>? jSONValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJSONValueVariant1 && jSONValueVariant1 != null)
            {
                return jSONValueVariant1(JSONValueVariant1!);
            }
            else if (IsJSONValueVariant2 && jSONValueVariant2 != null)
            {
                return jSONValueVariant2(JSONValueVariant2!);
            }
            else if (IsJSONValueVariant3 && jSONValueVariant3 != null)
            {
                return jSONValueVariant3(JSONValueVariant3!);
            }
            else if (IsJSONValueVariant4 && jSONValueVariant4 != null)
            {
                return jSONValueVariant4(JSONValueVariant4!);
            }
            else if (IsJSONValueVariant5 && jSONValueVariant5 != null)
            {
                return jSONValueVariant5(JSONValueVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? jSONValueVariant1 = null,
            global::System.Action<double?>? jSONValueVariant2 = null,
            global::System.Action<bool?>? jSONValueVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.JSONValue>?>? jSONValueVariant4 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?>? jSONValueVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJSONValueVariant1)
            {
                jSONValueVariant1?.Invoke(JSONValueVariant1!);
            }
            else if (IsJSONValueVariant2)
            {
                jSONValueVariant2?.Invoke(JSONValueVariant2!);
            }
            else if (IsJSONValueVariant3)
            {
                jSONValueVariant3?.Invoke(JSONValueVariant3!);
            }
            else if (IsJSONValueVariant4)
            {
                jSONValueVariant4?.Invoke(JSONValueVariant4!);
            }
            else if (IsJSONValueVariant5)
            {
                jSONValueVariant5?.Invoke(JSONValueVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JSONValueVariant1,
                typeof(string),
                JSONValueVariant2,
                typeof(double),
                JSONValueVariant3,
                typeof(bool),
                JSONValueVariant4,
                typeof(global::System.Collections.Generic.IList<global::G.JSONValue>),
                JSONValueVariant5,
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
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JSONValueVariant1, other.JSONValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(JSONValueVariant2, other.JSONValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(JSONValueVariant3, other.JSONValueVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.JSONValue>?>.Default.Equals(JSONValueVariant4, other.JSONValueVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::G.JSONValue?>?>.Default.Equals(JSONValueVariant5, other.JSONValueVariant5) 
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
