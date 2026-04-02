//HintName: G.Models.ObjectsGetResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ObjectsGetResponse : global::System.IEquatable<ObjectsGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Object? ObjectValue { get; init; }
#else
        public global::G.Object? ObjectValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ObjectsGetResponseVariant2? ObjectsGetResponseVariant2 { get; init; }
#else
        public global::G.ObjectsGetResponseVariant2? ObjectsGetResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectsGetResponseVariant2))]
#endif
        public bool IsObjectsGetResponseVariant2 => ObjectsGetResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ObjectsGetResponseVariant3? ObjectsGetResponseVariant3 { get; init; }
#else
        public global::G.ObjectsGetResponseVariant3? ObjectsGetResponseVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectsGetResponseVariant3))]
#endif
        public bool IsObjectsGetResponseVariant3 => ObjectsGetResponseVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObjectsGetResponse(global::G.Object value) => new ObjectsGetResponse((global::G.Object?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Object?(ObjectsGetResponse @this) => @this.ObjectValue;

        /// <summary>
        /// 
        /// </summary>
        public ObjectsGetResponse(global::G.Object? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObjectsGetResponse(global::G.ObjectsGetResponseVariant2 value) => new ObjectsGetResponse((global::G.ObjectsGetResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ObjectsGetResponseVariant2?(ObjectsGetResponse @this) => @this.ObjectsGetResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ObjectsGetResponse(global::G.ObjectsGetResponseVariant2? value)
        {
            ObjectsGetResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObjectsGetResponse(global::G.ObjectsGetResponseVariant3 value) => new ObjectsGetResponse((global::G.ObjectsGetResponseVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ObjectsGetResponseVariant3?(ObjectsGetResponse @this) => @this.ObjectsGetResponseVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ObjectsGetResponse(global::G.ObjectsGetResponseVariant3? value)
        {
            ObjectsGetResponseVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectsGetResponse(
            global::G.Object? objectValue,
            global::G.ObjectsGetResponseVariant2? objectsGetResponseVariant2,
            global::G.ObjectsGetResponseVariant3? objectsGetResponseVariant3
            )
        {
            ObjectValue = objectValue;
            ObjectsGetResponseVariant2 = objectsGetResponseVariant2;
            ObjectsGetResponseVariant3 = objectsGetResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObjectsGetResponseVariant3 as object ??
            ObjectsGetResponseVariant2 as object ??
            ObjectValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObjectValue?.ToString() ??
            ObjectsGetResponseVariant2?.ToString() ??
            ObjectsGetResponseVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObjectValue && IsObjectsGetResponseVariant2 && IsObjectsGetResponseVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Object?, TResult>? objectValue = null,
            global::System.Func<global::G.ObjectsGetResponseVariant2?, TResult>? objectsGetResponseVariant2 = null,
            global::System.Func<global::G.ObjectsGetResponseVariant3?, TResult>? objectsGetResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsObjectsGetResponseVariant2 && objectsGetResponseVariant2 != null)
            {
                return objectsGetResponseVariant2(ObjectsGetResponseVariant2!);
            }
            else if (IsObjectsGetResponseVariant3 && objectsGetResponseVariant3 != null)
            {
                return objectsGetResponseVariant3(ObjectsGetResponseVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Object?>? objectValue = null,
            global::System.Action<global::G.ObjectsGetResponseVariant2?>? objectsGetResponseVariant2 = null,
            global::System.Action<global::G.ObjectsGetResponseVariant3?>? objectsGetResponseVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsObjectsGetResponseVariant2)
            {
                objectsGetResponseVariant2?.Invoke(ObjectsGetResponseVariant2!);
            }
            else if (IsObjectsGetResponseVariant3)
            {
                objectsGetResponseVariant3?.Invoke(ObjectsGetResponseVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObjectValue,
                typeof(global::G.Object),
                ObjectsGetResponseVariant2,
                typeof(global::G.ObjectsGetResponseVariant2),
                ObjectsGetResponseVariant3,
                typeof(global::G.ObjectsGetResponseVariant3),
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
        public bool Equals(ObjectsGetResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Object?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ObjectsGetResponseVariant2?>.Default.Equals(ObjectsGetResponseVariant2, other.ObjectsGetResponseVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ObjectsGetResponseVariant3?>.Default.Equals(ObjectsGetResponseVariant3, other.ObjectsGetResponseVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ObjectsGetResponse obj1, ObjectsGetResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ObjectsGetResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ObjectsGetResponse obj1, ObjectsGetResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObjectsGetResponse o && Equals(o);
        }
    }
}
