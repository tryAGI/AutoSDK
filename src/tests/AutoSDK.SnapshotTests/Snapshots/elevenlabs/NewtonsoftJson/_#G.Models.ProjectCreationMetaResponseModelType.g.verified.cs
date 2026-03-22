//HintName: G.Models.ProjectCreationMetaResponseModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the project creation action.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectCreationMetaResponseModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_assign_voices")]
        AutoAssignVoices,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blank")]
        Blank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dub_video")]
        DubVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generate_podcast")]
        GeneratePodcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="import_speech")]
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