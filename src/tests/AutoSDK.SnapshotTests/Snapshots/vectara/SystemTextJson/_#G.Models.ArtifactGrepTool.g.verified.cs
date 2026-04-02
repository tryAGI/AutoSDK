//HintName: G.Models.ArtifactGrepTool.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that searches through an artifact's content using grep with support for all standard grep options.
    /// </summary>
    public readonly partial struct ArtifactGrepTool : global::System.IEquatable<ArtifactGrepTool>
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
        public global::G.ArtifactGrepToolVariant2? ArtifactGrepToolVariant2 { get; init; }
#else
        public global::G.ArtifactGrepToolVariant2? ArtifactGrepToolVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArtifactGrepToolVariant2))]
#endif
        public bool IsArtifactGrepToolVariant2 => ArtifactGrepToolVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactGrepTool(global::G.ToolBase value) => new ArtifactGrepTool((global::G.ToolBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolBase?(ArtifactGrepTool @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepTool(global::G.ToolBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArtifactGrepTool(global::G.ArtifactGrepToolVariant2 value) => new ArtifactGrepTool((global::G.ArtifactGrepToolVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ArtifactGrepToolVariant2?(ArtifactGrepTool @this) => @this.ArtifactGrepToolVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepTool(global::G.ArtifactGrepToolVariant2? value)
        {
            ArtifactGrepToolVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArtifactGrepTool(
            global::G.ToolBase? @base,
            global::G.ArtifactGrepToolVariant2? artifactGrepToolVariant2
            )
        {
            Base = @base;
            ArtifactGrepToolVariant2 = artifactGrepToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ArtifactGrepToolVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ArtifactGrepToolVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsArtifactGrepToolVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ToolBase?, TResult>? @base = null,
            global::System.Func<global::G.ArtifactGrepToolVariant2?, TResult>? artifactGrepToolVariant2 = null,
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
            else if (IsArtifactGrepToolVariant2 && artifactGrepToolVariant2 != null)
            {
                return artifactGrepToolVariant2(ArtifactGrepToolVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ToolBase?>? @base = null,
            global::System.Action<global::G.ArtifactGrepToolVariant2?>? artifactGrepToolVariant2 = null,
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
            else if (IsArtifactGrepToolVariant2)
            {
                artifactGrepToolVariant2?.Invoke(ArtifactGrepToolVariant2!);
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
                ArtifactGrepToolVariant2,
                typeof(global::G.ArtifactGrepToolVariant2),
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
        public bool Equals(ArtifactGrepTool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ToolBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ArtifactGrepToolVariant2?>.Default.Equals(ArtifactGrepToolVariant2, other.ArtifactGrepToolVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArtifactGrepTool obj1, ArtifactGrepTool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArtifactGrepTool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArtifactGrepTool obj1, ArtifactGrepTool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArtifactGrepTool o && Equals(o);
        }
    }
}
