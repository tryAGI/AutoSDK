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
        [global::System.Runtime.Serialization.EnumMember(Value="blank")]
        Blank,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generate_podcast")]
        GeneratePodcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_assign_voices")]
        AutoAssignVoices,
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
                ProjectCreationMetaResponseModelType.Blank => "blank",
                ProjectCreationMetaResponseModelType.GeneratePodcast => "generate_podcast",
                ProjectCreationMetaResponseModelType.AutoAssignVoices => "auto_assign_voices",
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
                "blank" => ProjectCreationMetaResponseModelType.Blank,
                "generate_podcast" => ProjectCreationMetaResponseModelType.GeneratePodcast,
                "auto_assign_voices" => ProjectCreationMetaResponseModelType.AutoAssignVoices,
                _ => null,
            };
        }
    }
}