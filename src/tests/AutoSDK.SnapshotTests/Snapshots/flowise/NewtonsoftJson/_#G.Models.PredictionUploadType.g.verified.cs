//HintName: G.Models.PredictionUploadType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of file upload<br/>
    /// Example: file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionUploadType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file:full")]
        File_full,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file:rag")]
        File_rag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionUploadType value)
        {
            return value switch
            {
                PredictionUploadType.Audio => "audio",
                PredictionUploadType.File => "file",
                PredictionUploadType.File_full => "file:full",
                PredictionUploadType.File_rag => "file:rag",
                PredictionUploadType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionUploadType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => PredictionUploadType.Audio,
                "file" => PredictionUploadType.File,
                "file:full" => PredictionUploadType.File_full,
                "file:rag" => PredictionUploadType.File_rag,
                "url" => PredictionUploadType.Url,
                _ => null,
            };
        }
    }
}