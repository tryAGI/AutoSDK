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
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_file")]
        InvalidFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_error")]
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unsupported_file")]
        UnsupportedFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileObjectLastErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileObjectLastErrorCode value)
        {
            return value switch
            {
                VectorStoreFileObjectLastErrorCode.InvalidFile => "invalid_file",
                VectorStoreFileObjectLastErrorCode.ServerError => "server_error",
                VectorStoreFileObjectLastErrorCode.UnsupportedFile => "unsupported_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileObjectLastErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_file" => VectorStoreFileObjectLastErrorCode.InvalidFile,
                "server_error" => VectorStoreFileObjectLastErrorCode.ServerError,
                "unsupported_file" => VectorStoreFileObjectLastErrorCode.UnsupportedFile,
                _ => null,
            };
        }
    }
}