//HintName: G.Models.UpdateEmbeddingsPayload.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateEmbeddingsPayload : global::System.IEquatable<UpdateEmbeddingsPayload>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? UpdateEmbeddingsPayloadVariant1 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? UpdateEmbeddingsPayloadVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateEmbeddingsPayloadVariant1))]
#endif
        public bool IsUpdateEmbeddingsPayloadVariant1 => UpdateEmbeddingsPayloadVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? UpdateEmbeddingsPayloadVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? UpdateEmbeddingsPayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateEmbeddingsPayloadVariant2))]
#endif
        public bool IsUpdateEmbeddingsPayloadVariant2 => UpdateEmbeddingsPayloadVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public UpdateEmbeddingsPayload(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? updateEmbeddingsPayloadVariant1,
            global::System.Collections.Generic.IList<string>? updateEmbeddingsPayloadVariant2
            )
        {
            UpdateEmbeddingsPayloadVariant1 = updateEmbeddingsPayloadVariant1;
            UpdateEmbeddingsPayloadVariant2 = updateEmbeddingsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateEmbeddingsPayloadVariant2 as object ??
            UpdateEmbeddingsPayloadVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UpdateEmbeddingsPayloadVariant1?.ToString() ??
            UpdateEmbeddingsPayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpdateEmbeddingsPayloadVariant1 && !IsUpdateEmbeddingsPayloadVariant2 || !IsUpdateEmbeddingsPayloadVariant1 && IsUpdateEmbeddingsPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?, TResult>? updateEmbeddingsPayloadVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<string>?, TResult>? updateEmbeddingsPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateEmbeddingsPayloadVariant1 && updateEmbeddingsPayloadVariant1 != null)
            {
                return updateEmbeddingsPayloadVariant1(UpdateEmbeddingsPayloadVariant1!);
            }
            else if (IsUpdateEmbeddingsPayloadVariant2 && updateEmbeddingsPayloadVariant2 != null)
            {
                return updateEmbeddingsPayloadVariant2(UpdateEmbeddingsPayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>? updateEmbeddingsPayloadVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<string>?>? updateEmbeddingsPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateEmbeddingsPayloadVariant1)
            {
                updateEmbeddingsPayloadVariant1?.Invoke(UpdateEmbeddingsPayloadVariant1!);
            }
            else if (IsUpdateEmbeddingsPayloadVariant2)
            {
                updateEmbeddingsPayloadVariant2?.Invoke(UpdateEmbeddingsPayloadVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateEmbeddingsPayloadVariant1,
                typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>),
                UpdateEmbeddingsPayloadVariant2,
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
        public bool Equals(UpdateEmbeddingsPayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>?>.Default.Equals(UpdateEmbeddingsPayloadVariant1, other.UpdateEmbeddingsPayloadVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(UpdateEmbeddingsPayloadVariant2, other.UpdateEmbeddingsPayloadVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateEmbeddingsPayload obj1, UpdateEmbeddingsPayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateEmbeddingsPayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateEmbeddingsPayload obj1, UpdateEmbeddingsPayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateEmbeddingsPayload o && Equals(o);
        }
    }
}
