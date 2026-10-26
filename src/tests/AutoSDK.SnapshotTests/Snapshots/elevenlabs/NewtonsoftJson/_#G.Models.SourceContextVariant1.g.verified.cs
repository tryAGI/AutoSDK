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
        public global::G.SongSourceContext? Song { get; init; }
#else
        public global::G.SongSourceContext? Song { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Song))]
#endif
        public bool IsSong => Song != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSong(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SongSourceContext? value)
        {
            value = Song;
            return IsSong;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SongSourceContext PickSong() => Song is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Song' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MusicExploreSongSourceContext? MusicExploreSong { get; init; }
#else
        public global::G.MusicExploreSongSourceContext? MusicExploreSong { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MusicExploreSong))]
#endif
        public bool IsMusicExploreSong => MusicExploreSong != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMusicExploreSong(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.MusicExploreSongSourceContext? value)
        {
            value = MusicExploreSong;
            return IsMusicExploreSong;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.MusicExploreSongSourceContext PickMusicExploreSong() => MusicExploreSong is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MusicExploreSong' but the value was {ToString()}.");

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
        public bool TryPickSfx(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.SfxSourceContext? value)
        {
            value = Sfx;
            return IsSfx;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.SfxSourceContext PickSfx() => Sfx is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sfx' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourceContextVariant1(global::G.SongSourceContext value) => new SourceContextVariant1((global::G.SongSourceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SongSourceContext?(SourceContextVariant1 @this) => @this.Song;

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(global::G.SongSourceContext? value)
        {
            Song = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SourceContextVariant1 FromSong(global::G.SongSourceContext? value) => new SourceContextVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourceContextVariant1(global::G.MusicExploreSongSourceContext value) => new SourceContextVariant1((global::G.MusicExploreSongSourceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MusicExploreSongSourceContext?(SourceContextVariant1 @this) => @this.MusicExploreSong;

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(global::G.MusicExploreSongSourceContext? value)
        {
            MusicExploreSong = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SourceContextVariant1 FromMusicExploreSong(global::G.MusicExploreSongSourceContext? value) => new SourceContextVariant1(value);

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
        public static SourceContextVariant1 FromSfx(global::G.SfxSourceContext? value) => new SourceContextVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public SourceContextVariant1(
            global::G.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? sourceType,
            global::G.SongSourceContext? song,
            global::G.MusicExploreSongSourceContext? musicExploreSong,
            global::G.SfxSourceContext? sfx
            )
        {
            SourceType = sourceType;

            Song = song;
            MusicExploreSong = musicExploreSong;
            Sfx = sfx;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sfx as object ??
            MusicExploreSong as object ??
            Song as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Song?.ToString() ??
            MusicExploreSong?.ToString() ??
            Sfx?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSong && !IsMusicExploreSong && !IsSfx || !IsSong && IsMusicExploreSong && !IsSfx || !IsSong && !IsMusicExploreSong && IsSfx;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SongSourceContext, TResult>? song = null,
            global::System.Func<global::G.MusicExploreSongSourceContext, TResult>? musicExploreSong = null,
            global::System.Func<global::G.SfxSourceContext, TResult>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0 && song != null)
            {
                return song(__value0);
            }
            else if (MusicExploreSong is { } __value1 && musicExploreSong != null)
            {
                return musicExploreSong(__value1);
            }
            else if (Sfx is { } __value2 && sfx != null)
            {
                return sfx(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SongSourceContext>? song = null,

            global::System.Action<global::G.MusicExploreSongSourceContext>? musicExploreSong = null,

            global::System.Action<global::G.SfxSourceContext>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0)
            {
                song?.Invoke(__value0);
            }
            else if (MusicExploreSong is { } __value1)
            {
                musicExploreSong?.Invoke(__value1);
            }
            else if (Sfx is { } __value2)
            {
                sfx?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.SongSourceContext>? song = null,
            global::System.Action<global::G.MusicExploreSongSourceContext>? musicExploreSong = null,
            global::System.Action<global::G.SfxSourceContext>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0)
            {
                song?.Invoke(__value0);
            }
            else if (MusicExploreSong is { } __value1)
            {
                musicExploreSong?.Invoke(__value1);
            }
            else if (Sfx is { } __value2)
            {
                sfx?.Invoke(__value2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Song,
                typeof(global::G.SongSourceContext),
                MusicExploreSong,
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
                global::System.Collections.Generic.EqualityComparer<global::G.SongSourceContext?>.Default.Equals(Song, other.Song) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MusicExploreSongSourceContext?>.Default.Equals(MusicExploreSong, other.MusicExploreSong) &&
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
