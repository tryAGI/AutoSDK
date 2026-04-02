//HintName: G.Models.JsonListStringWrite.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JsonListStringWrite : global::System.IEquatable<JsonListStringWrite>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonListStringWriteVariant1 { get; init; }
#else
        public object? JsonListStringWriteVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringWriteVariant1))]
#endif
        public bool IsJsonListStringWriteVariant1 => JsonListStringWriteVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? JsonListStringWriteVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? JsonListStringWriteVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringWriteVariant2))]
#endif
        public bool IsJsonListStringWriteVariant2 => JsonListStringWriteVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonListStringWriteVariant3 { get; init; }
#else
        public string? JsonListStringWriteVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringWriteVariant3))]
#endif
        public bool IsJsonListStringWriteVariant3 => JsonListStringWriteVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonListStringWrite(string value) => new JsonListStringWrite((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonListStringWrite @this) => @this.JsonListStringWriteVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringWrite(string? value)
        {
            JsonListStringWriteVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringWrite(
            object? jsonListStringWriteVariant1,
            global::System.Collections.Generic.IList<object>? jsonListStringWriteVariant2,
            string? jsonListStringWriteVariant3
            )
        {
            JsonListStringWriteVariant1 = jsonListStringWriteVariant1;
            JsonListStringWriteVariant2 = jsonListStringWriteVariant2;
            JsonListStringWriteVariant3 = jsonListStringWriteVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonListStringWriteVariant3 as object ??
            JsonListStringWriteVariant2 as object ??
            JsonListStringWriteVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonListStringWriteVariant1?.ToString() ??
            JsonListStringWriteVariant2?.ToString() ??
            JsonListStringWriteVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonListStringWriteVariant1 || IsJsonListStringWriteVariant2 || IsJsonListStringWriteVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? jsonListStringWriteVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? jsonListStringWriteVariant2 = null,
            global::System.Func<string?, TResult>? jsonListStringWriteVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringWriteVariant1 && jsonListStringWriteVariant1 != null)
            {
                return jsonListStringWriteVariant1(JsonListStringWriteVariant1!);
            }
            else if (IsJsonListStringWriteVariant2 && jsonListStringWriteVariant2 != null)
            {
                return jsonListStringWriteVariant2(JsonListStringWriteVariant2!);
            }
            else if (IsJsonListStringWriteVariant3 && jsonListStringWriteVariant3 != null)
            {
                return jsonListStringWriteVariant3(JsonListStringWriteVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? jsonListStringWriteVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? jsonListStringWriteVariant2 = null,
            global::System.Action<string?>? jsonListStringWriteVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringWriteVariant1)
            {
                jsonListStringWriteVariant1?.Invoke(JsonListStringWriteVariant1!);
            }
            else if (IsJsonListStringWriteVariant2)
            {
                jsonListStringWriteVariant2?.Invoke(JsonListStringWriteVariant2!);
            }
            else if (IsJsonListStringWriteVariant3)
            {
                jsonListStringWriteVariant3?.Invoke(JsonListStringWriteVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonListStringWriteVariant1,
                typeof(object),
                JsonListStringWriteVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
                JsonListStringWriteVariant3,
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
        public bool Equals(JsonListStringWrite other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonListStringWriteVariant1, other.JsonListStringWriteVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(JsonListStringWriteVariant2, other.JsonListStringWriteVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonListStringWriteVariant3, other.JsonListStringWriteVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonListStringWrite obj1, JsonListStringWrite obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonListStringWrite>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonListStringWrite obj1, JsonListStringWrite obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonListStringWrite o && Equals(o);
        }
    }
}
