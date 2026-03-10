//HintName: G.Models.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        MusicExploreSong,
        /// <summary>
        /// 
        /// </summary>
        Sfx,
        /// <summary>
        /// 
        /// </summary>
        Song,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType value)
        {
            return value switch
            {
                ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong => "music_explore_song",
                ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Sfx => "sfx",
                ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Song => "song",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? ToEnum(string value)
        {
            return value switch
            {
                "music_explore_song" => ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong,
                "sfx" => ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Sfx,
                "song" => ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Song,
                _ => null,
            };
        }
    }
}