//HintName: G.Models.GetWalletPackageResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWalletPackageResponseItemIn
    {
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Path,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWalletPackageResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWalletPackageResponseItemIn value)
        {
            return value switch
            {
                GetWalletPackageResponseItemIn.Body => "body",
                GetWalletPackageResponseItemIn.Cookie => "cookie",
                GetWalletPackageResponseItemIn.Header => "header",
                GetWalletPackageResponseItemIn.Path => "path",
                GetWalletPackageResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWalletPackageResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => GetWalletPackageResponseItemIn.Body,
                "cookie" => GetWalletPackageResponseItemIn.Cookie,
                "header" => GetWalletPackageResponseItemIn.Header,
                "path" => GetWalletPackageResponseItemIn.Path,
                "query" => GetWalletPackageResponseItemIn.Query,
                _ => null,
            };
        }
    }
}