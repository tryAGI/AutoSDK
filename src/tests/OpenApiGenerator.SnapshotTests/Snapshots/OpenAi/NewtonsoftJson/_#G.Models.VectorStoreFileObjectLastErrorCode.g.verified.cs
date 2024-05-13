//HintName: G.Models.VectorStoreFileObjectLastErrorCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// One of `server_error` or `rate_limit_exceeded`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VectorStoreFileObjectLastErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal_error")]
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_not_found")]
        FileNotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parsing_error")]
        ParsingError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unhandled_mime_type")]
        UnhandledMimeType,
    }
}