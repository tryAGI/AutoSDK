//HintName: G.Models.ImageReadTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that loads image artifacts into the conversation context for viewing and analysis.
    /// </summary>
    public readonly partial struct ImageReadTool : global::System.IEquatable<ImageReadTool>
    {
        /// <summary>
        /// Base properties shared by all tool types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolBase? Base { get; init; }
#else
        public global::G.ToolBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ImageReadToolVariant2? ImageReadToolVariant2 { get; init; }
#else
        public global::G.ImageReadToolVariant2? ImageReadToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReadToolVariant2))]
#endif
        public bool IsImageReadToolVariant2 => ImageReadToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTool(global::G.ToolBase value) => new ImageReadTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(ImageReadTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ImageReadTool(global::G.ImageReadToolVariant2 value) => new ImageReadTool((global::G.ImageReadToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ImageReadToolVariant2?(ImageReadTool @this) => @this.ImageReadToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(global::G.ImageReadToolVariant2? value)
        {
            ImageReadToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ImageReadTool(
            global::G.ToolBase? @base,
            global::G.ImageReadToolVariant2? imageReadToolVariant2
            )
        {
            Base = @base;
            ImageReadToolVariant2 = imageReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ImageReadToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ImageReadToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsImageReadToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.ImageReadToolVariant2?, TResult>? imageReadToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsImageReadToolVariant2 && imageReadToolVariant2 != null)
            {
                return imageReadToolVariant2(ImageReadToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.ImageReadToolVariant2?>? imageReadToolVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsImageReadToolVariant2)
            {
                imageReadToolVariant2?.Invoke(ImageReadToolVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.ToolBase),
                ImageReadToolVariant2,
                typeof(global::G.ImageReadToolVariant2),
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
        public bool Equals(ImageReadTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ImageReadToolVariant2?>.Default.Equals(ImageReadToolVariant2, other.ImageReadToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ImageReadTool obj1, ImageReadTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImageReadTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ImageReadTool obj1, ImageReadTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageReadTool o && Equals(o);
        }
    }
}
