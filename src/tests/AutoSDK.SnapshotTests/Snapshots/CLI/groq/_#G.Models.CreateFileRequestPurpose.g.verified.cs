//HintName: G.Models.CreateFileRequestPurpose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The intended purpose of the uploaded file.<br/>
    /// Use "batch" for [Batch API](/docs/api-reference#batches).
    /// </summary>
    public enum CreateFileRequestPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        Batch,
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
                CreateFileRequestPurpose.Batch => "batch",
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
                "batch" => CreateFileRequestPurpose.Batch,
                _ => null,
            };
        }
    }
}