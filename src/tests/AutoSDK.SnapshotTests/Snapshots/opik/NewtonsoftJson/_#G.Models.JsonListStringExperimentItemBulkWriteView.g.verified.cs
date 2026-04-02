//HintName: G.Models.JsonListStringExperimentItemBulkWriteView.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct JsonListStringExperimentItemBulkWriteView : global::System.IEquatable<JsonListStringExperimentItemBulkWriteView>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? JsonListStringExperimentItemBulkWriteViewVariant1 { get; init; }
#else
        public object? JsonListStringExperimentItemBulkWriteViewVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringExperimentItemBulkWriteViewVariant1))]
#endif
        public bool IsJsonListStringExperimentItemBulkWriteViewVariant1 => JsonListStringExperimentItemBulkWriteViewVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? JsonListStringExperimentItemBulkWriteViewVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? JsonListStringExperimentItemBulkWriteViewVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringExperimentItemBulkWriteViewVariant2))]
#endif
        public bool IsJsonListStringExperimentItemBulkWriteViewVariant2 => JsonListStringExperimentItemBulkWriteViewVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? JsonListStringExperimentItemBulkWriteViewVariant3 { get; init; }
#else
        public string? JsonListStringExperimentItemBulkWriteViewVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonListStringExperimentItemBulkWriteViewVariant3))]
#endif
        public bool IsJsonListStringExperimentItemBulkWriteViewVariant3 => JsonListStringExperimentItemBulkWriteViewVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JsonListStringExperimentItemBulkWriteView(string value) => new JsonListStringExperimentItemBulkWriteView((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(JsonListStringExperimentItemBulkWriteView @this) => @this.JsonListStringExperimentItemBulkWriteViewVariant3;

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringExperimentItemBulkWriteView(string? value)
        {
            JsonListStringExperimentItemBulkWriteViewVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JsonListStringExperimentItemBulkWriteView(
            object? jsonListStringExperimentItemBulkWriteViewVariant1,
            global::System.Collections.Generic.IList<object>? jsonListStringExperimentItemBulkWriteViewVariant2,
            string? jsonListStringExperimentItemBulkWriteViewVariant3
            )
        {
            JsonListStringExperimentItemBulkWriteViewVariant1 = jsonListStringExperimentItemBulkWriteViewVariant1;
            JsonListStringExperimentItemBulkWriteViewVariant2 = jsonListStringExperimentItemBulkWriteViewVariant2;
            JsonListStringExperimentItemBulkWriteViewVariant3 = jsonListStringExperimentItemBulkWriteViewVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonListStringExperimentItemBulkWriteViewVariant3 as object ??
            JsonListStringExperimentItemBulkWriteViewVariant2 as object ??
            JsonListStringExperimentItemBulkWriteViewVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonListStringExperimentItemBulkWriteViewVariant1?.ToString() ??
            JsonListStringExperimentItemBulkWriteViewVariant2?.ToString() ??
            JsonListStringExperimentItemBulkWriteViewVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonListStringExperimentItemBulkWriteViewVariant1 || IsJsonListStringExperimentItemBulkWriteViewVariant2 || IsJsonListStringExperimentItemBulkWriteViewVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? jsonListStringExperimentItemBulkWriteViewVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? jsonListStringExperimentItemBulkWriteViewVariant2 = null,
            global::System.Func<string?, TResult>? jsonListStringExperimentItemBulkWriteViewVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringExperimentItemBulkWriteViewVariant1 && jsonListStringExperimentItemBulkWriteViewVariant1 != null)
            {
                return jsonListStringExperimentItemBulkWriteViewVariant1(JsonListStringExperimentItemBulkWriteViewVariant1!);
            }
            else if (IsJsonListStringExperimentItemBulkWriteViewVariant2 && jsonListStringExperimentItemBulkWriteViewVariant2 != null)
            {
                return jsonListStringExperimentItemBulkWriteViewVariant2(JsonListStringExperimentItemBulkWriteViewVariant2!);
            }
            else if (IsJsonListStringExperimentItemBulkWriteViewVariant3 && jsonListStringExperimentItemBulkWriteViewVariant3 != null)
            {
                return jsonListStringExperimentItemBulkWriteViewVariant3(JsonListStringExperimentItemBulkWriteViewVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? jsonListStringExperimentItemBulkWriteViewVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? jsonListStringExperimentItemBulkWriteViewVariant2 = null,
            global::System.Action<string?>? jsonListStringExperimentItemBulkWriteViewVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonListStringExperimentItemBulkWriteViewVariant1)
            {
                jsonListStringExperimentItemBulkWriteViewVariant1?.Invoke(JsonListStringExperimentItemBulkWriteViewVariant1!);
            }
            else if (IsJsonListStringExperimentItemBulkWriteViewVariant2)
            {
                jsonListStringExperimentItemBulkWriteViewVariant2?.Invoke(JsonListStringExperimentItemBulkWriteViewVariant2!);
            }
            else if (IsJsonListStringExperimentItemBulkWriteViewVariant3)
            {
                jsonListStringExperimentItemBulkWriteViewVariant3?.Invoke(JsonListStringExperimentItemBulkWriteViewVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JsonListStringExperimentItemBulkWriteViewVariant1,
                typeof(object),
                JsonListStringExperimentItemBulkWriteViewVariant2,
                typeof(global::System.Collections.Generic.IList<object>),
                JsonListStringExperimentItemBulkWriteViewVariant3,
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
        public bool Equals(JsonListStringExperimentItemBulkWriteView other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(JsonListStringExperimentItemBulkWriteViewVariant1, other.JsonListStringExperimentItemBulkWriteViewVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(JsonListStringExperimentItemBulkWriteViewVariant2, other.JsonListStringExperimentItemBulkWriteViewVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(JsonListStringExperimentItemBulkWriteViewVariant3, other.JsonListStringExperimentItemBulkWriteViewVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JsonListStringExperimentItemBulkWriteView obj1, JsonListStringExperimentItemBulkWriteView obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JsonListStringExperimentItemBulkWriteView>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JsonListStringExperimentItemBulkWriteView obj1, JsonListStringExperimentItemBulkWriteView obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JsonListStringExperimentItemBulkWriteView o && Equals(o);
        }
    }
}
