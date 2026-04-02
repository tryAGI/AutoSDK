//HintName: G.Models.JsonListStringPublic.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JsonListStringPublic : global::System.IEquatable<JsonListStringPublic>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonListStringPublicVariant1 { get; init; }
#else
        public object? JsonListStringPublicVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringPublicVariant1))]
#endif
        public bool IsJsonListStringPublicVariant1 => JsonListStringPublicVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? JsonListStringPublicVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? JsonListStringPublicVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringPublicVariant2))]
#endif
        public bool IsJsonListStringPublicVariant2 => JsonListStringPublicVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonListStringPublicVariant3 { get; init; }
#else
        public string? JsonListStringPublicVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringPublicVariant3))]
#endif
        public bool IsJsonListStringPublicVariant3 => JsonListStringPublicVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonListStringPublic(string value) => new JsonListStringPublic((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonListStringPublic @this) => @this.JsonListStringPublicVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringPublic(string? value)
        {
            JsonListStringPublicVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringPublic(
            object? jsonListStringPublicVariant1,
            global::System.Collections.Generic.IList<object>? jsonListStringPublicVariant2,
            string? jsonListStringPublicVariant3
            )
        {
            JsonListStringPublicVariant1 = jsonListStringPublicVariant1;
            JsonListStringPublicVariant2 = jsonListStringPublicVariant2;
            JsonListStringPublicVariant3 = jsonListStringPublicVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonListStringPublicVariant3 as object ??
            JsonListStringPublicVariant2 as object ??
            JsonListStringPublicVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonListStringPublicVariant1?.ToString() ??
            JsonListStringPublicVariant2?.ToString() ??
            JsonListStringPublicVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonListStringPublicVariant1 || IsJsonListStringPublicVariant2 || IsJsonListStringPublicVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? jsonListStringPublicVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? jsonListStringPublicVariant2 = null,
            global::System.Func<string?, TResult>? jsonListStringPublicVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringPublicVariant1 && jsonListStringPublicVariant1 != null)
            {
                return jsonListStringPublicVariant1(JsonListStringPublicVariant1!);
            }
            else if (IsJsonListStringPublicVariant2 && jsonListStringPublicVariant2 != null)
            {
                return jsonListStringPublicVariant2(JsonListStringPublicVariant2!);
            }
            else if (IsJsonListStringPublicVariant3 && jsonListStringPublicVariant3 != null)
            {
                return jsonListStringPublicVariant3(JsonListStringPublicVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? jsonListStringPublicVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? jsonListStringPublicVariant2 = null,
            global::System.Action<string?>? jsonListStringPublicVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringPublicVariant1)
            {
                jsonListStringPublicVariant1?.Invoke(JsonListStringPublicVariant1!);
            }
            else if (IsJsonListStringPublicVariant2)
            {
                jsonListStringPublicVariant2?.Invoke(JsonListStringPublicVariant2!);
            }
            else if (IsJsonListStringPublicVariant3)
            {
                jsonListStringPublicVariant3?.Invoke(JsonListStringPublicVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonListStringPublicVariant1,
                typeof(object),
                JsonListStringPublicVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
                JsonListStringPublicVariant3,
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
        public bool Equals(JsonListStringPublic other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonListStringPublicVariant1, other.JsonListStringPublicVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(JsonListStringPublicVariant2, other.JsonListStringPublicVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonListStringPublicVariant3, other.JsonListStringPublicVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonListStringPublic obj1, JsonListStringPublic obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonListStringPublic>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonListStringPublic obj1, JsonListStringPublic obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonListStringPublic o && Equals(o);
        }
    }
}
