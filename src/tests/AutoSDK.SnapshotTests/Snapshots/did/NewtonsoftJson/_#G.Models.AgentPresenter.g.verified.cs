//HintName: G.Models.AgentPresenter.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentPresenter : global::System.IEquatable<AgentPresenter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentPresenterPhotoAvatar? PhotoAvatar { get; init; }
#else
        public global::G.AgentPresenterPhotoAvatar? PhotoAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhotoAvatar))]
#endif
        public bool IsPhotoAvatar => PhotoAvatar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentPresenterVideoAvatar? VideoAvatar { get; init; }
#else
        public global::G.AgentPresenterVideoAvatar? VideoAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoAvatar))]
#endif
        public bool IsVideoAvatar => VideoAvatar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentPresenterExpressiveAvatar? ExpressiveAvatar { get; init; }
#else
        public global::G.AgentPresenterExpressiveAvatar? ExpressiveAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExpressiveAvatar))]
#endif
        public bool IsExpressiveAvatar => ExpressiveAvatar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentPresenter(global::G.AgentPresenterPhotoAvatar value) => new AgentPresenter((global::G.AgentPresenterPhotoAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentPresenterPhotoAvatar?(AgentPresenter @this) => @this.PhotoAvatar;

        /// <summary>
        /// 
        /// </summary>
        public AgentPresenter(global::G.AgentPresenterPhotoAvatar? value)
        {
            PhotoAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentPresenter(global::G.AgentPresenterVideoAvatar value) => new AgentPresenter((global::G.AgentPresenterVideoAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentPresenterVideoAvatar?(AgentPresenter @this) => @this.VideoAvatar;

        /// <summary>
        /// 
        /// </summary>
        public AgentPresenter(global::G.AgentPresenterVideoAvatar? value)
        {
            VideoAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentPresenter(global::G.AgentPresenterExpressiveAvatar value) => new AgentPresenter((global::G.AgentPresenterExpressiveAvatar?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentPresenterExpressiveAvatar?(AgentPresenter @this) => @this.ExpressiveAvatar;

        /// <summary>
        /// 
        /// </summary>
        public AgentPresenter(global::G.AgentPresenterExpressiveAvatar? value)
        {
            ExpressiveAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentPresenter(
            global::G.AgentPresenterPhotoAvatar? photoAvatar,
            global::G.AgentPresenterVideoAvatar? videoAvatar,
            global::G.AgentPresenterExpressiveAvatar? expressiveAvatar
            )
        {
            PhotoAvatar = photoAvatar;
            VideoAvatar = videoAvatar;
            ExpressiveAvatar = expressiveAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExpressiveAvatar as object ??
            VideoAvatar as object ??
            PhotoAvatar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PhotoAvatar?.ToString() ??
            VideoAvatar?.ToString() ??
            ExpressiveAvatar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPhotoAvatar || IsVideoAvatar || IsExpressiveAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentPresenterPhotoAvatar?, TResult>? photoAvatar = null,
            global::System.Func<global::G.AgentPresenterVideoAvatar?, TResult>? videoAvatar = null,
            global::System.Func<global::G.AgentPresenterExpressiveAvatar?, TResult>? expressiveAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhotoAvatar && photoAvatar != null)
            {
                return photoAvatar(PhotoAvatar!);
            }
            else if (IsVideoAvatar && videoAvatar != null)
            {
                return videoAvatar(VideoAvatar!);
            }
            else if (IsExpressiveAvatar && expressiveAvatar != null)
            {
                return expressiveAvatar(ExpressiveAvatar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentPresenterPhotoAvatar?>? photoAvatar = null,
            global::System.Action<global::G.AgentPresenterVideoAvatar?>? videoAvatar = null,
            global::System.Action<global::G.AgentPresenterExpressiveAvatar?>? expressiveAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhotoAvatar)
            {
                photoAvatar?.Invoke(PhotoAvatar!);
            }
            else if (IsVideoAvatar)
            {
                videoAvatar?.Invoke(VideoAvatar!);
            }
            else if (IsExpressiveAvatar)
            {
                expressiveAvatar?.Invoke(ExpressiveAvatar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PhotoAvatar,
                typeof(global::G.AgentPresenterPhotoAvatar),
                VideoAvatar,
                typeof(global::G.AgentPresenterVideoAvatar),
                ExpressiveAvatar,
                typeof(global::G.AgentPresenterExpressiveAvatar),
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
        public bool Equals(AgentPresenter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentPresenterPhotoAvatar?>.Default.Equals(PhotoAvatar, other.PhotoAvatar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentPresenterVideoAvatar?>.Default.Equals(VideoAvatar, other.VideoAvatar) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentPresenterExpressiveAvatar?>.Default.Equals(ExpressiveAvatar, other.ExpressiveAvatar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentPresenter obj1, AgentPresenter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentPresenter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentPresenter obj1, AgentPresenter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentPresenter o && Equals(o);
        }
    }
}
