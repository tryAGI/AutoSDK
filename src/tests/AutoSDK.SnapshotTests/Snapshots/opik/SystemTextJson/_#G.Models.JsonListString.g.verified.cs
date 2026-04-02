//HintName: G.Models.JsonListString.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JsonListString : global::System.IEquatable<JsonListString>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonListStringVariant1 { get; init; }
#else
        public object? JsonListStringVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringVariant1))]
#endif
        public bool IsJsonListStringVariant1 => JsonListStringVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? JsonListStringVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? JsonListStringVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringVariant2))]
#endif
        public bool IsJsonListStringVariant2 => JsonListStringVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonListStringVariant3 { get; init; }
#else
        public string? JsonListStringVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringVariant3))]
#endif
        public bool IsJsonListStringVariant3 => JsonListStringVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonListString(string value) => new JsonListString((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonListString @this) => @this.JsonListStringVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonListString(string? value)
        {
            JsonListStringVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonListString(
            object? jsonListStringVariant1,
            global::System.Collections.Generic.IList<object>? jsonListStringVariant2,
            string? jsonListStringVariant3
            )
        {
            JsonListStringVariant1 = jsonListStringVariant1;
            JsonListStringVariant2 = jsonListStringVariant2;
            JsonListStringVariant3 = jsonListStringVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonListStringVariant3 as object ??
            JsonListStringVariant2 as object ??
            JsonListStringVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonListStringVariant1?.ToString() ??
            JsonListStringVariant2?.ToString() ??
            JsonListStringVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonListStringVariant1 || IsJsonListStringVariant2 || IsJsonListStringVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? jsonListStringVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? jsonListStringVariant2 = null,
            global::System.Func<string?, TResult>? jsonListStringVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringVariant1 && jsonListStringVariant1 != null)
            {
                return jsonListStringVariant1(JsonListStringVariant1!);
            }
            else if (IsJsonListStringVariant2 && jsonListStringVariant2 != null)
            {
                return jsonListStringVariant2(JsonListStringVariant2!);
            }
            else if (IsJsonListStringVariant3 && jsonListStringVariant3 != null)
            {
                return jsonListStringVariant3(JsonListStringVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? jsonListStringVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? jsonListStringVariant2 = null,
            global::System.Action<string?>? jsonListStringVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringVariant1)
            {
                jsonListStringVariant1?.Invoke(JsonListStringVariant1!);
            }
            else if (IsJsonListStringVariant2)
            {
                jsonListStringVariant2?.Invoke(JsonListStringVariant2!);
            }
            else if (IsJsonListStringVariant3)
            {
                jsonListStringVariant3?.Invoke(JsonListStringVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonListStringVariant1,
                typeof(object),
                JsonListStringVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
                JsonListStringVariant3,
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
        public bool Equals(JsonListString other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonListStringVariant1, other.JsonListStringVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(JsonListStringVariant2, other.JsonListStringVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonListStringVariant3, other.JsonListStringVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonListString obj1, JsonListString obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonListString>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonListString obj1, JsonListString obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonListString o && Equals(o);
        }
    }
}
