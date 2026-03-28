//HintName: G.Models.ApiEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividechatDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividechatDividemoderations,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Divideembeddings,
        /// <summary>
        /// 
        /// </summary>
        Dividev1DividefimDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        Dividev1Dividemoderations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiEndpoint value)
        {
            return value switch
            {
                ApiEndpoint.Dividev1DividechatDividecompletions => "/v1/chat/completions",
                ApiEndpoint.Dividev1DividechatDividemoderations => "/v1/chat/moderations",
                ApiEndpoint.Dividev1Divideembeddings => "/v1/embeddings",
                ApiEndpoint.Dividev1DividefimDividecompletions => "/v1/fim/completions",
                ApiEndpoint.Dividev1Dividemoderations => "/v1/moderations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "/v1/chat/completions" => ApiEndpoint.Dividev1DividechatDividecompletions,
                "/v1/chat/moderations" => ApiEndpoint.Dividev1DividechatDividemoderations,
                "/v1/embeddings" => ApiEndpoint.Dividev1Divideembeddings,
                "/v1/fim/completions" => ApiEndpoint.Dividev1DividefimDividecompletions,
                "/v1/moderations" => ApiEndpoint.Dividev1Dividemoderations,
                _ => null,
            };
        }
    }
}