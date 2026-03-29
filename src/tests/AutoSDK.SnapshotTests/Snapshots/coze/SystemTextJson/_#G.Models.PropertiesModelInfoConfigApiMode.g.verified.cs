//HintName: G.Models.PropertiesModelInfoConfigApiMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 模型的API协议
    /// </summary>
    public enum PropertiesModelInfoConfigApiMode
    {
        /// <summary>
        /// 
        /// </summary>
        ChatApi,
        /// <summary>
        /// 
        /// </summary>
        ResponsesApi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesModelInfoConfigApiModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesModelInfoConfigApiMode value)
        {
            return value switch
            {
                PropertiesModelInfoConfigApiMode.ChatApi => "chat_api",
                PropertiesModelInfoConfigApiMode.ResponsesApi => "responses_api",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesModelInfoConfigApiMode? ToEnum(string value)
        {
            return value switch
            {
                "chat_api" => PropertiesModelInfoConfigApiMode.ChatApi,
                "responses_api" => PropertiesModelInfoConfigApiMode.ResponsesApi,
                _ => null,
            };
        }
    }
}