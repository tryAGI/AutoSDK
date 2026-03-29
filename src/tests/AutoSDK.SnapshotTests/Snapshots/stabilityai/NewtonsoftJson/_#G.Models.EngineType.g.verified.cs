//HintName: G.Models.EngineType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content this engine produces<br/>
    /// Example: PICTURE
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EngineType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AUDIO")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLASSIFICATION")]
        Classification,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PICTURE")]
        Picture,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STORAGE")]
        Storage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXT")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIDEO")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EngineTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EngineType value)
        {
            return value switch
            {
                EngineType.Audio => "AUDIO",
                EngineType.Classification => "CLASSIFICATION",
                EngineType.Picture => "PICTURE",
                EngineType.Storage => "STORAGE",
                EngineType.Text => "TEXT",
                EngineType.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EngineType? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => EngineType.Audio,
                "CLASSIFICATION" => EngineType.Classification,
                "PICTURE" => EngineType.Picture,
                "STORAGE" => EngineType.Storage,
                "TEXT" => EngineType.Text,
                "VIDEO" => EngineType.Video,
                _ => null,
            };
        }
    }
}