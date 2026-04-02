//HintName: G.Models.JsonListStringCompare.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public readonly partial struct JsonListStringCompare : global::System.IEquatable<JsonListStringCompare>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonListStringCompareVariant1 { get; init; }
#else
        public object? JsonListStringCompareVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringCompareVariant1))]
#endif
        public bool IsJsonListStringCompareVariant1 => JsonListStringCompareVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? JsonListStringCompareVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? JsonListStringCompareVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringCompareVariant2))]
#endif
        public bool IsJsonListStringCompareVariant2 => JsonListStringCompareVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonListStringCompareVariant3 { get; init; }
#else
        public string? JsonListStringCompareVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringCompareVariant3))]
#endif
        public bool IsJsonListStringCompareVariant3 => JsonListStringCompareVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonListStringCompare(string value) => new JsonListStringCompare((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonListStringCompare @this) => @this.JsonListStringCompareVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringCompare(string? value)
        {
            JsonListStringCompareVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringCompare(
            object? jsonListStringCompareVariant1,
            global::System.Collections.Generic.IList<object>? jsonListStringCompareVariant2,
            string? jsonListStringCompareVariant3
            )
        {
            JsonListStringCompareVariant1 = jsonListStringCompareVariant1;
            JsonListStringCompareVariant2 = jsonListStringCompareVariant2;
            JsonListStringCompareVariant3 = jsonListStringCompareVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonListStringCompareVariant3 as object ??
            JsonListStringCompareVariant2 as object ??
            JsonListStringCompareVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonListStringCompareVariant1?.ToString() ??
            JsonListStringCompareVariant2?.ToString() ??
            JsonListStringCompareVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonListStringCompareVariant1 || IsJsonListStringCompareVariant2 || IsJsonListStringCompareVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? jsonListStringCompareVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? jsonListStringCompareVariant2 = null,
            global::System.Func<string?, TResult>? jsonListStringCompareVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringCompareVariant1 && jsonListStringCompareVariant1 != null)
            {
                return jsonListStringCompareVariant1(JsonListStringCompareVariant1!);
            }
            else if (IsJsonListStringCompareVariant2 && jsonListStringCompareVariant2 != null)
            {
                return jsonListStringCompareVariant2(JsonListStringCompareVariant2!);
            }
            else if (IsJsonListStringCompareVariant3 && jsonListStringCompareVariant3 != null)
            {
                return jsonListStringCompareVariant3(JsonListStringCompareVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? jsonListStringCompareVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? jsonListStringCompareVariant2 = null,
            global::System.Action<string?>? jsonListStringCompareVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringCompareVariant1)
            {
                jsonListStringCompareVariant1?.Invoke(JsonListStringCompareVariant1!);
            }
            else if (IsJsonListStringCompareVariant2)
            {
                jsonListStringCompareVariant2?.Invoke(JsonListStringCompareVariant2!);
            }
            else if (IsJsonListStringCompareVariant3)
            {
                jsonListStringCompareVariant3?.Invoke(JsonListStringCompareVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonListStringCompareVariant1,
                typeof(object),
                JsonListStringCompareVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
                JsonListStringCompareVariant3,
                typeof(string),
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
        public bool Equals(JsonListStringCompare other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonListStringCompareVariant1, other.JsonListStringCompareVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(JsonListStringCompareVariant2, other.JsonListStringCompareVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonListStringCompareVariant3, other.JsonListStringCompareVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonListStringCompare obj1, JsonListStringCompare obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonListStringCompare>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonListStringCompare obj1, JsonListStringCompare obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonListStringCompare o && Equals(o);
        }
    }
}
