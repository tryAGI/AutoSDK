//HintName: G.Models.ProjectCreationMetaResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the project creation action.
    /// </summary>
    public enum ProjectCreationMetaResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        AutoAssignVoices,
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        DubVideo,
        /// <summary>
        /// 
        /// </summary>
        GeneratePodcast,
        /// <summary>
        /// 
        /// </summary>
        ImportSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectCreationMetaResponseModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectCreationMetaResponseModelType value)
        {
            return value switch
            {
                ProjectCreationMetaResponseModelType.AutoAssignVoices => "auto_assign_voices",
                ProjectCreationMetaResponseModelType.Blank => "blank",
                ProjectCreationMetaResponseModelType.DubVideo => "dub_video",
                ProjectCreationMetaResponseModelType.GeneratePodcast => "generate_podcast",
                ProjectCreationMetaResponseModelType.ImportSpeech => "import_speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectCreationMetaResponseModelType? ToEnum(string value)
        {
            return value switch
            {
                "auto_assign_voices" => ProjectCreationMetaResponseModelType.AutoAssignVoices,
                "blank" => ProjectCreationMetaResponseModelType.Blank,
                "dub_video" => ProjectCreationMetaResponseModelType.DubVideo,
                "generate_podcast" => ProjectCreationMetaResponseModelType.GeneratePodcast,
                "import_speech" => ProjectCreationMetaResponseModelType.ImportSpeech,
                _ => null,
            };
        }
    }
}