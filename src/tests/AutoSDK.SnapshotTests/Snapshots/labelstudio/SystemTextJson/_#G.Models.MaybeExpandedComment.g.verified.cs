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
        public global::G.Comment? Comment { get; init; }
#else
        public global::G.Comment? Comment { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Comment))]
#endif
        public bool IsComment => Comment != null;

        /// <summary>
        /// Comment Serializer with FSM state support.<br/>
        /// Note: The 'state' field will be populated from the queryset annotation<br/>
        /// if present, preventing N+1 queries. Use .with_state() on your queryset.<br/>
        /// The state field display is controlled by both:<br/>
        /// - fflag_feat_fit_568_finite_state_management (FSM background calculations)<br/>
        /// - fflag_feat_fit_710_fsm_state_fields (state field display in APIs)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CommentSerializerWithExpandedUser? SerializerWithUser { get; init; }
#else
        public global::G.CommentSerializerWithExpandedUser? SerializerWithUser { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SerializerWithUser))]
#endif
        public bool IsSerializerWithUser => SerializerWithUser != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaybeExpandedComment(global::G.Comment value) => new MaybeExpandedComment((global::G.Comment?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Comment?(MaybeExpandedComment @this) => @this.Comment;

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(global::G.Comment? value)
        {
            Comment = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MaybeExpandedComment(global::G.CommentSerializerWithExpandedUser value) => new MaybeExpandedComment((global::G.CommentSerializerWithExpandedUser?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CommentSerializerWithExpandedUser?(MaybeExpandedComment @this) => @this.SerializerWithUser;

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(global::G.CommentSerializerWithExpandedUser? value)
        {
            SerializerWithUser = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MaybeExpandedComment(
            global::G.Comment? comment,
            global::G.CommentSerializerWithExpandedUser? serializerWithUser
            )
        {
            Comment = comment;
            SerializerWithUser = serializerWithUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SerializerWithUser as object ??
            Comment as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Comment?.ToString() ??
            SerializerWithUser?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsComment && !IsSerializerWithUser || !IsComment && IsSerializerWithUser;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Comment?, TResult>? comment = null,
            global::System.Func<global::G.CommentSerializerWithExpandedUser?, TResult>? serializerWithUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComment && comment != null)
            {
                return comment(Comment!);
            }
            else if (IsSerializerWithUser && serializerWithUser != null)
            {
                return serializerWithUser(SerializerWithUser!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Comment?>? comment = null,
            global::System.Action<global::G.CommentSerializerWithExpandedUser?>? serializerWithUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsComment)
            {
                comment?.Invoke(Comment!);
            }
            else if (IsSerializerWithUser)
            {
                serializerWithUser?.Invoke(SerializerWithUser!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Comment,
                typeof(global::G.Comment),
                SerializerWithUser,
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
                global::System.Collections.Generic.EqualityComparer<global::G.Comment?>.Default.Equals(Comment, other.Comment) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CommentSerializerWithExpandedUser?>.Default.Equals(SerializerWithUser, other.SerializerWithUser) 
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
