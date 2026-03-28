//HintName: G.Models.ApiEndpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/chat/completions")]
        Dividev1DividechatDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/chat/moderations")]
        Dividev1DividechatDividemoderations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/embeddings")]
        Dividev1Divideembeddings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/fim/completions")]
        Dividev1DividefimDividecompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="/v1/moderations")]
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