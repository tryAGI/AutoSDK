//HintName: G.Models.VectorStoreFileObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    public enum VectorStoreFileObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        FileNotFound,
        /// <summary>
        /// 
        /// </summary>
        ParsingError,
        /// <summary>
        /// 
        /// </summary>
        UnhandledMimeType,
    }

    public static class VectorStoreFileObjectLastErrorCodeExtensions
    {
        public static string ToValueString(this VectorStoreFileObjectLastErrorCode value)
        {
            return value switch
            {
                VectorStoreFileObjectLastErrorCode.InternalError => "internal_error",
                VectorStoreFileObjectLastErrorCode.FileNotFound => "file_not_found",
                VectorStoreFileObjectLastErrorCode.ParsingError => "parsing_error",
                VectorStoreFileObjectLastErrorCode.UnhandledMimeType => "unhandled_mime_type",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectLastErrorCode ToEnum(string value)
        {
            return value switch
            {
                "internal_error" => VectorStoreFileObjectLastErrorCode.InternalError,
                "file_not_found" => VectorStoreFileObjectLastErrorCode.FileNotFound,
                "parsing_error" => VectorStoreFileObjectLastErrorCode.ParsingError,
                "unhandled_mime_type" => VectorStoreFileObjectLastErrorCode.UnhandledMimeType,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VectorStoreFileObjectLastErrorCode ToEnum(int value)
        {
            return value switch
            {
                0 => VectorStoreFileObjectLastErrorCode.InternalError,
                1 => VectorStoreFileObjectLastErrorCode.FileNotFound,
                2 => VectorStoreFileObjectLastErrorCode.ParsingError,
                3 => VectorStoreFileObjectLastErrorCode.UnhandledMimeType,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}