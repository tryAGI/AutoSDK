//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file. One of: - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFileRequestPurpose
    {
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistants")]
        Assistants,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batch")]
        Batch,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine-tune")]
        FineTune,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vision")]
        Vision,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_data")]
        UserData,
        /// <summary>
        /// - `assistants`: Used in the Assistants API - `batch`: Used in the Batch API - `fine-tune`: Used for fine-tuning - `vision`: Images used for vision fine-tuning - `user_data`: Flexible file type for any purpose - `evals`: Used for eval data sets
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evals")]
        Evals,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFileRequestPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFileRequestPurpose value)
        {
            return value switch
            {
                CreateFileRequestPurpose.Assistants => "assistants",
                CreateFileRequestPurpose.Batch => "batch",
                CreateFileRequestPurpose.FineTune => "fine-tune",
                CreateFileRequestPurpose.Vision => "vision",
                CreateFileRequestPurpose.UserData => "user_data",
                CreateFileRequestPurpose.Evals => "evals",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFileRequestPurpose? ToEnum(string value)
        {
            return value switch
            {
                "assistants" => CreateFileRequestPurpose.Assistants,
                "batch" => CreateFileRequestPurpose.Batch,
                "fine-tune" => CreateFileRequestPurpose.FineTune,
                "vision" => CreateFileRequestPurpose.Vision,
                "user_data" => CreateFileRequestPurpose.UserData,
                "evals" => CreateFileRequestPurpose.Evals,
                _ => null,
            };
        }
    }
}