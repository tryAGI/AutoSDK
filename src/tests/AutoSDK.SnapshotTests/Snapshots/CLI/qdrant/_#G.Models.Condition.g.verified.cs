//HintName: G.Models.Condition.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Condition : global::System.IEquatable<Condition>
    {
        /// <summary>
        /// All possible payload filtering conditions
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FieldCondition? Field { get; init; }
#else
        public global::G.FieldCondition? Field { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Field))]
#endif
        public bool IsField => Field != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickField(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.FieldCondition? value)
        {
            value = Field;
            return IsField;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.FieldCondition PickField() => Field is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Field' but the value was {ToString()}.");

        /// <summary>
        /// Select points with empty payload for a specified field
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IsEmptyCondition? IsEmpty { get; init; }
#else
        public global::G.IsEmptyCondition? IsEmpty { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IsEmpty))]
#endif
        public bool IsIsEmpty => IsEmpty != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIsEmpty(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.IsEmptyCondition? value)
        {
            value = IsEmpty;
            return IsIsEmpty;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.IsEmptyCondition PickIsEmpty() => IsEmpty is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IsEmpty' but the value was {ToString()}.");

        /// <summary>
        /// Select points with null payload for a specified field
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.IsNullCondition? IsNull { get; init; }
#else
        public global::G.IsNullCondition? IsNull { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IsNull))]
#endif
        public bool IsIsNull => IsNull != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIsNull(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.IsNullCondition? value)
        {
            value = IsNull;
            return IsIsNull;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.IsNullCondition PickIsNull() => IsNull is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'IsNull' but the value was {ToString()}.");

        /// <summary>
        /// ID-based filtering condition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HasIdCondition? HasId { get; init; }
#else
        public global::G.HasIdCondition? HasId { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HasId))]
#endif
        public bool IsHasId => HasId != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHasId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.HasIdCondition? value)
        {
            value = HasId;
            return IsHasId;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.HasIdCondition PickHasId() => HasId is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasId' but the value was {ToString()}.");

        /// <summary>
        /// Filter points which have specific vector assigned
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HasVectorCondition? HasVector { get; init; }
#else
        public global::G.HasVectorCondition? HasVector { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HasVector))]
#endif
        public bool IsHasVector => HasVector != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHasVector(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.HasVectorCondition? value)
        {
            value = HasVector;
            return IsHasVector;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.HasVectorCondition PickHasVector() => HasVector is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasVector' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NestedCondition? Nested { get; init; }
#else
        public global::G.NestedCondition? Nested { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Nested))]
#endif
        public bool IsNested => Nested != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNested(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.NestedCondition? value)
        {
            value = Nested;
            return IsNested;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.NestedCondition PickNested() => Nested is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Nested' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Filter? Filter { get; init; }
#else
        public global::G.Filter? Filter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Filter))]
#endif
        public bool IsFilter => Filter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFilter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.Filter? value)
        {
            value = Filter;
            return IsFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.Filter PickFilter() => Filter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Filter' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.FieldCondition value) => new Condition((global::G.FieldCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FieldCondition?(Condition @this) => @this.Field;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.FieldCondition? value)
        {
            Field = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromField(global::G.FieldCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.IsEmptyCondition value) => new Condition((global::G.IsEmptyCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IsEmptyCondition?(Condition @this) => @this.IsEmpty;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.IsEmptyCondition? value)
        {
            IsEmpty = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromIsEmpty(global::G.IsEmptyCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.IsNullCondition value) => new Condition((global::G.IsNullCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.IsNullCondition?(Condition @this) => @this.IsNull;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.IsNullCondition? value)
        {
            IsNull = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromIsNull(global::G.IsNullCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.HasIdCondition value) => new Condition((global::G.HasIdCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HasIdCondition?(Condition @this) => @this.HasId;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.HasIdCondition? value)
        {
            HasId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromHasId(global::G.HasIdCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.HasVectorCondition value) => new Condition((global::G.HasVectorCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HasVectorCondition?(Condition @this) => @this.HasVector;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.HasVectorCondition? value)
        {
            HasVector = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromHasVector(global::G.HasVectorCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.NestedCondition value) => new Condition((global::G.NestedCondition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NestedCondition?(Condition @this) => @this.Nested;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.NestedCondition? value)
        {
            Nested = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromNested(global::G.NestedCondition? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Condition(global::G.Filter value) => new Condition((global::G.Filter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Filter?(Condition @this) => @this.Filter;

        /// <summary>
        /// 
        /// </summary>
        public Condition(global::G.Filter? value)
        {
            Filter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Condition FromFilter(global::G.Filter? value) => new Condition(value);

        /// <summary>
        /// 
        /// </summary>
        public Condition(
            global::G.FieldCondition? field,
            global::G.IsEmptyCondition? isEmpty,
            global::G.IsNullCondition? isNull,
            global::G.HasIdCondition? hasId,
            global::G.HasVectorCondition? hasVector,
            global::G.NestedCondition? nested,
            global::G.Filter? filter
            )
        {
            Field = field;
            IsEmpty = isEmpty;
            IsNull = isNull;
            HasId = hasId;
            HasVector = hasVector;
            Nested = nested;
            Filter = filter;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Filter as object ??
            Nested as object ??
            HasVector as object ??
            HasId as object ??
            IsNull as object ??
            IsEmpty as object ??
            Field as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Field?.ToString() ??
            IsEmpty?.ToString() ??
            IsNull?.ToString() ??
            HasId?.ToString() ??
            HasVector?.ToString() ??
            Nested?.ToString() ??
            Filter?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsField || IsIsEmpty || IsIsNull || IsHasId || IsHasVector || IsNested || IsFilter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FieldCondition, TResult>? field = null,
            global::System.Func<global::G.IsEmptyCondition, TResult>? isEmpty = null,
            global::System.Func<global::G.IsNullCondition, TResult>? isNull = null,
            global::System.Func<global::G.HasIdCondition, TResult>? hasId = null,
            global::System.Func<global::G.HasVectorCondition, TResult>? hasVector = null,
            global::System.Func<global::G.NestedCondition, TResult>? nested = null,
            global::System.Func<global::G.Filter, TResult>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0 && field != null)
            {
                return field(__value0);
            }
            else if (IsEmpty is { } __value1 && isEmpty != null)
            {
                return isEmpty(__value1);
            }
            else if (IsNull is { } __value2 && isNull != null)
            {
                return isNull(__value2);
            }
            else if (HasId is { } __value3 && hasId != null)
            {
                return hasId(__value3);
            }
            else if (HasVector is { } __value4 && hasVector != null)
            {
                return hasVector(__value4);
            }
            else if (Nested is { } __value5 && nested != null)
            {
                return nested(__value5);
            }
            else if (Filter is { } __value6 && filter != null)
            {
                return filter(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FieldCondition>? field = null,

            global::System.Action<global::G.IsEmptyCondition>? isEmpty = null,

            global::System.Action<global::G.IsNullCondition>? isNull = null,

            global::System.Action<global::G.HasIdCondition>? hasId = null,

            global::System.Action<global::G.HasVectorCondition>? hasVector = null,

            global::System.Action<global::G.NestedCondition>? nested = null,

            global::System.Action<global::G.Filter>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0)
            {
                field?.Invoke(__value0);
            }
            else if (IsEmpty is { } __value1)
            {
                isEmpty?.Invoke(__value1);
            }
            else if (IsNull is { } __value2)
            {
                isNull?.Invoke(__value2);
            }
            else if (HasId is { } __value3)
            {
                hasId?.Invoke(__value3);
            }
            else if (HasVector is { } __value4)
            {
                hasVector?.Invoke(__value4);
            }
            else if (Nested is { } __value5)
            {
                nested?.Invoke(__value5);
            }
            else if (Filter is { } __value6)
            {
                filter?.Invoke(__value6);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.FieldCondition>? field = null,
            global::System.Action<global::G.IsEmptyCondition>? isEmpty = null,
            global::System.Action<global::G.IsNullCondition>? isNull = null,
            global::System.Action<global::G.HasIdCondition>? hasId = null,
            global::System.Action<global::G.HasVectorCondition>? hasVector = null,
            global::System.Action<global::G.NestedCondition>? nested = null,
            global::System.Action<global::G.Filter>? filter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Field is { } __value0)
            {
                field?.Invoke(__value0);
            }
            else if (IsEmpty is { } __value1)
            {
                isEmpty?.Invoke(__value1);
            }
            else if (IsNull is { } __value2)
            {
                isNull?.Invoke(__value2);
            }
            else if (HasId is { } __value3)
            {
                hasId?.Invoke(__value3);
            }
            else if (HasVector is { } __value4)
            {
                hasVector?.Invoke(__value4);
            }
            else if (Nested is { } __value5)
            {
                nested?.Invoke(__value5);
            }
            else if (Filter is { } __value6)
            {
                filter?.Invoke(__value6);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Field,
                typeof(global::G.FieldCondition),
                IsEmpty,
                typeof(global::G.IsEmptyCondition),
                IsNull,
                typeof(global::G.IsNullCondition),
                HasId,
                typeof(global::G.HasIdCondition),
                HasVector,
                typeof(global::G.HasVectorCondition),
                Nested,
                typeof(global::G.NestedCondition),
                Filter,
                typeof(global::G.Filter),
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
        public bool Equals(Condition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FieldCondition?>.Default.Equals(Field, other.Field) &&
                global::System.Collections.Generic.EqualityComparer<global::G.IsEmptyCondition?>.Default.Equals(IsEmpty, other.IsEmpty) &&
                global::System.Collections.Generic.EqualityComparer<global::G.IsNullCondition?>.Default.Equals(IsNull, other.IsNull) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HasIdCondition?>.Default.Equals(HasId, other.HasId) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HasVectorCondition?>.Default.Equals(HasVector, other.HasVector) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NestedCondition?>.Default.Equals(Nested, other.Nested) &&
                global::System.Collections.Generic.EqualityComparer<global::G.Filter?>.Default.Equals(Filter, other.Filter) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Condition obj1, Condition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Condition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Condition obj1, Condition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Condition o && Equals(o);
        }
    }
}
