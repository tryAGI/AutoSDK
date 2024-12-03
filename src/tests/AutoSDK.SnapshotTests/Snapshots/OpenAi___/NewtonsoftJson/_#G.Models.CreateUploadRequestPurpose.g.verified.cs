//HintName: G.Models.CreateUploadRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.<br/>
    /// See the [documentation on File purposes](/docs/api-reference/files/create#files-create-purpose).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateUploadRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistants")]
        Assistants,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vision")]
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUploadRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUploadRequestPurpose value)
        {
            return value switch
            {
                CreateUploadRequestPurpose.Assistants => "assistants",
                CreateUploadRequestPurpose.Batch => "batch",
                CreateUploadRequestPurpose.FineTune => "fine-tune",
                CreateUploadRequestPurpose.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUploadRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateUploadRequestPurpose.Assistants,
                "batch" => CreateUploadRequestPurpose.Batch,
                "fine-tune" => CreateUploadRequestPurpose.FineTune,
                "vision" => CreateUploadRequestPurpose.Vision,
                _ => null,
            };
        }
    }
}