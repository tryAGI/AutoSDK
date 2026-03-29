//HintName: G.Models.AuthorName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthorName
    {
        /// <summary>
        /// 
        /// </summary>
        Alibaba,
        /// <summary>
        /// 
        /// </summary>
        Amazon,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Baidu,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        MetaLlama,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Moonshotai,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Passthrough,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Qwen,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Zai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthorName value)
        {
            return value switch
            {
                AuthorName.Alibaba => "alibaba",
                AuthorName.Amazon => "amazon",
                AuthorName.Anthropic => "anthropic",
                AuthorName.Baidu => "baidu",
                AuthorName.Deepseek => "deepseek",
                AuthorName.Google => "google",
                AuthorName.MetaLlama => "meta-llama",
                AuthorName.Microsoft => "microsoft",
                AuthorName.Mistral => "mistral",
                AuthorName.Moonshotai => "moonshotai",
                AuthorName.Nvidia => "nvidia",
                AuthorName.Openai => "openai",
                AuthorName.Passthrough => "passthrough",
                AuthorName.Perplexity => "perplexity",
                AuthorName.Qwen => "qwen",
                AuthorName.Xai => "xai",
                AuthorName.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthorName? ToEnum(string value)
        {
            return value switch
            {
                "alibaba" => AuthorName.Alibaba,
                "amazon" => AuthorName.Amazon,
                "anthropic" => AuthorName.Anthropic,
                "baidu" => AuthorName.Baidu,
                "deepseek" => AuthorName.Deepseek,
                "google" => AuthorName.Google,
                "meta-llama" => AuthorName.MetaLlama,
                "microsoft" => AuthorName.Microsoft,
                "mistral" => AuthorName.Mistral,
                "moonshotai" => AuthorName.Moonshotai,
                "nvidia" => AuthorName.Nvidia,
                "openai" => AuthorName.Openai,
                "passthrough" => AuthorName.Passthrough,
                "perplexity" => AuthorName.Perplexity,
                "qwen" => AuthorName.Qwen,
                "xai" => AuthorName.Xai,
                "zai" => AuthorName.Zai,
                _ => null,
            };
        }
    }
}