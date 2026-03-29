//HintName: G.Models.ReturnChatGroupPagedAudioReconstructionsPaginationDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReturnChatGroupPagedAudioReconstructionsPaginationDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatGroupPagedAudioReconstructionsPaginationDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatGroupPagedAudioReconstructionsPaginationDirection value)
        {
            return value switch
            {
                ReturnChatGroupPagedAudioReconstructionsPaginationDirection.Asc => "ASC",
                ReturnChatGroupPagedAudioReconstructionsPaginationDirection.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatGroupPagedAudioReconstructionsPaginationDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ReturnChatGroupPagedAudioReconstructionsPaginationDirection.Asc,
                "DESC" => ReturnChatGroupPagedAudioReconstructionsPaginationDirection.Desc,
                _ => null,
            };
        }
    }
}