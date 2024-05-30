//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.
    /// Use "assistants" for [Assistants](/docs/api-reference/assistants) and [Message](/docs/api-reference/messages) files, "vision" for Assistants image file inputs, "batch" for [Batch API](/docs/guides/batch), and "fine-tune" for [Fine-tuning](/docs/api-reference/fine-tuning).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFileRequestPurpose
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
    }

    public static class CreateFileRequestPurposeExtensions
    {
        public static string ToValueString(this CreateFileRequestPurpose value)
        {
            return value switch
            {
                CreateFileRequestPurpose.Assistants => "assistants",
                CreateFileRequestPurpose.Batch => "batch",
                CreateFileRequestPurpose.FineTune => "fine-tune",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFileRequestPurpose ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateFileRequestPurpose.Assistants,
                "batch" => CreateFileRequestPurpose.Batch,
                "fine-tune" => CreateFileRequestPurpose.FineTune,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFileRequestPurpose ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFileRequestPurpose.Assistants,
                1 => CreateFileRequestPurpose.Batch,
                2 => CreateFileRequestPurpose.FineTune,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}