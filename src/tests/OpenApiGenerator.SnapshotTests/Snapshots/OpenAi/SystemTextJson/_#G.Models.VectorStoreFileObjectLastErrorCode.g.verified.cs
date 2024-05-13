//HintName: G.Models.VectorStoreFileObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    public abstract class VectorStoreFileObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        public const string InternalError = "internal_error";
        /// <summary>
        /// 
        /// </summary>
        public const string FileNotFound = "file_not_found";
        /// <summary>
        /// 
        /// </summary>
        public const string ParsingError = "parsing_error";
        /// <summary>
        /// 
        /// </summary>
        public const string UnhandledMimeType = "unhandled_mime_type";
    }
}