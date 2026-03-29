//HintName: G.Models.GetWalletApiCreditResponseItemIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWalletApiCreditResponseItemIn
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
    public static class GetWalletApiCreditResponseItemInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWalletApiCreditResponseItemIn value)
        {
            return value switch
            {
                GetWalletApiCreditResponseItemIn.Body => "body",
                GetWalletApiCreditResponseItemIn.Cookie => "cookie",
                GetWalletApiCreditResponseItemIn.Header => "header",
                GetWalletApiCreditResponseItemIn.Path => "path",
                GetWalletApiCreditResponseItemIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWalletApiCreditResponseItemIn? ToEnum(string value)
        {
            return value switch
            {
                "body" => GetWalletApiCreditResponseItemIn.Body,
                "cookie" => GetWalletApiCreditResponseItemIn.Cookie,
                "header" => GetWalletApiCreditResponseItemIn.Header,
                "path" => GetWalletApiCreditResponseItemIn.Path,
                "query" => GetWalletApiCreditResponseItemIn.Query,
                _ => null,
            };
        }
    }
}