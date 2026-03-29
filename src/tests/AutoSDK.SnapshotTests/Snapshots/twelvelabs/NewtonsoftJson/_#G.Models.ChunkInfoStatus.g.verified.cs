//HintName: G.Models.ChunkInfoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of this chunk. This field can take one of the following values:<br/>
    /// - `completed`: Successfully uploaded and reported.<br/>
    /// - `pending`: Not yet reported. A chunk may be in this status if it has been uploaded but not yet reported.<br/>
    /// - `failed`: The upload process failed; you must retry uploading this chunk.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChunkInfoStatus
    {
        /// <summary>
        /// Successfully uploaded and reported.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// The upload process failed; you must retry uploading this chunk.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// Not yet reported. A chunk may be in this status if it has been uploaded but not yet reported.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkInfoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkInfoStatus value)
        {
            return value switch
            {
                ChunkInfoStatus.Completed => "completed",
                ChunkInfoStatus.Failed => "failed",
                ChunkInfoStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkInfoStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChunkInfoStatus.Completed,
                "failed" => ChunkInfoStatus.Failed,
                "pending" => ChunkInfoStatus.Pending,
                _ => null,
            };
        }
    }
}