//HintName: G.Models.SourceContextVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SourceContextVariant1 : global::System.IEquatable<SourceContextVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? SourceType { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SongSourceContext? MusicExploreSong1 { get; init; }
#else
        public global::G.SongSourceContext? MusicExploreSong1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MusicExploreSong1))]
#endif
        public bool IsMusicExploreSong1 => MusicExploreSong1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MusicExploreSongSourceContext? MusicExploreSong2 { get; init; }
#else
        public global::G.MusicExploreSongSourceContext? MusicExploreSong2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MusicExploreSong2))]
#endif
        public bool IsMusicExploreSong2 => MusicExploreSong2 != null;

        /// <summary>
        /// Context for sound effect clips.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SfxSourceContext? Sfx { get; init; }
#else
        public global::G.SfxSourceContext? Sfx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sfx))]
#endif
        public bool IsSfx => Sfx != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourceContextVariant1(global::G.SongSourceContext value) => new SourceContextVariant1((global::G.SongSourceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SongSourceContext?(SourceContextVariant1 @this) => @this.MusicExploreSong1;

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(global::G.SongSourceContext? value)
        {
            MusicExploreSong1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourceContextVariant1(global::G.MusicExploreSongSourceContext value) => new SourceContextVariant1((global::G.MusicExploreSongSourceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MusicExploreSongSourceContext?(SourceContextVariant1 @this) => @this.MusicExploreSong2;

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(global::G.MusicExploreSongSourceContext? value)
        {
            MusicExploreSong2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourceContextVariant1(global::G.SfxSourceContext value) => new SourceContextVariant1((global::G.SfxSourceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SfxSourceContext?(SourceContextVariant1 @this) => @this.Sfx;

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(global::G.SfxSourceContext? value)
        {
            Sfx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(
            global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? sourceType,
            global::G.SongSourceContext? musicExploreSong1,
            global::G.MusicExploreSongSourceContext? musicExploreSong2,
            global::G.SfxSourceContext? sfx
            )
        {
            SourceType = sourceType;

            MusicExploreSong1 = musicExploreSong1;
            MusicExploreSong2 = musicExploreSong2;
            Sfx = sfx;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sfx as object ??
            MusicExploreSong2 as object ??
            MusicExploreSong1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MusicExploreSong1?.ToString() ??
            MusicExploreSong2?.ToString() ??
            Sfx?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMusicExploreSong1 && !IsMusicExploreSong2 && !IsSfx || !IsMusicExploreSong1 && IsMusicExploreSong2 && !IsSfx || !IsMusicExploreSong1 && !IsMusicExploreSong2 && IsSfx;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SongSourceContext?, TResult>? musicExploreSong1 = null,
            global::System.Func<global::G.MusicExploreSongSourceContext?, TResult>? musicExploreSong2 = null,
            global::System.Func<global::G.SfxSourceContext?, TResult>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMusicExploreSong1 && musicExploreSong1 != null)
            {
                return musicExploreSong1(MusicExploreSong1!);
            }
            else if (IsMusicExploreSong2 && musicExploreSong2 != null)
            {
                return musicExploreSong2(MusicExploreSong2!);
            }
            else if (IsSfx && sfx != null)
            {
                return sfx(Sfx!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SongSourceContext?>? musicExploreSong1 = null,
            global::System.Action<global::G.MusicExploreSongSourceContext?>? musicExploreSong2 = null,
            global::System.Action<global::G.SfxSourceContext?>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMusicExploreSong1)
            {
                musicExploreSong1?.Invoke(MusicExploreSong1!);
            }
            else if (IsMusicExploreSong2)
            {
                musicExploreSong2?.Invoke(MusicExploreSong2!);
            }
            else if (IsSfx)
            {
                sfx?.Invoke(Sfx!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MusicExploreSong1,
                typeof(global::G.SongSourceContext),
                MusicExploreSong2,
                typeof(global::G.MusicExploreSongSourceContext),
                Sfx,
                typeof(global::G.SfxSourceContext),
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
        public bool Equals(SourceContextVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SongSourceContext?>.Default.Equals(MusicExploreSong1, other.MusicExploreSong1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MusicExploreSongSourceContext?>.Default.Equals(MusicExploreSong2, other.MusicExploreSong2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SfxSourceContext?>.Default.Equals(Sfx, other.Sfx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SourceContextVariant1 obj1, SourceContextVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SourceContextVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SourceContextVariant1 obj1, SourceContextVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SourceContextVariant1 o && Equals(o);
        }
    }
}
