//HintName: G.Models.MaybeExpandedComment.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MaybeExpandedComment : global::System.IEquatable<MaybeExpandedComment>
    {
        /// <summary>
        /// Comment Serializer with FSM state support.<br/>
        /// Note: The 'state' field will be populated from the queryset annotation<br/>
        /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
        /// The state field display is controlled by both:<br/>
        /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
        /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Comment? Value1 { get; init; }
#else
        public global::G.Comment? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Comment Serializer with FSM state support.<br/>
        /// Note: The 'state' field will be populated from the queryset annotation<br/>
        /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
        /// The state field display is controlled by both:<br/>
        /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
        /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CommentSerializerWithExpandedUser? Value2 { get; init; }
#else
        public global::G.CommentSerializerWithExpandedUser? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaybeExpandedComment(global::G.Comment value) => new MaybeExpandedComment((global::G.Comment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Comment?(MaybeExpandedComment @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(global::G.Comment? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaybeExpandedComment(global::G.CommentSerializerWithExpandedUser value) => new MaybeExpandedComment((global::G.CommentSerializerWithExpandedUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CommentSerializerWithExpandedUser?(MaybeExpandedComment @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(global::G.CommentSerializerWithExpandedUser? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(
            global::G.Comment? value1,
            global::G.CommentSerializerWithExpandedUser? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 || !IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Comment?, TResult>? value1 = null,
            global::System.Func<global::G.CommentSerializerWithExpandedUser?, TResult>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Comment?>? value1 = null,
            global::System.Action<global::G.CommentSerializerWithExpandedUser?>? value2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.Comment),
                Value2,
                typeof(global::G.CommentSerializerWithExpandedUser),
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
        public bool Equals(MaybeExpandedComment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Comment?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CommentSerializerWithExpandedUser?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MaybeExpandedComment obj1, MaybeExpandedComment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MaybeExpandedComment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MaybeExpandedComment obj1, MaybeExpandedComment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MaybeExpandedComment o && Equals(o);
        }
    }
}
