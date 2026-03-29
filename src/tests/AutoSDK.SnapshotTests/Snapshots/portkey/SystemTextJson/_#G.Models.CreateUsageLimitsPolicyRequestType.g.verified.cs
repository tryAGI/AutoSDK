//HintName: G.Models.CreateUsageLimitsPolicyRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Policy type
    /// </summary>
    public enum CreateUsageLimitsPolicyRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateUsageLimitsPolicyRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateUsageLimitsPolicyRequestType value)
        {
            return value switch
            {
                CreateUsageLimitsPolicyRequestType.Cost => "cost",
                CreateUsageLimitsPolicyRequestType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateUsageLimitsPolicyRequestType? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CreateUsageLimitsPolicyRequestType.Cost,
                "tokens" => CreateUsageLimitsPolicyRequestType.Tokens,
                _ => null,
            };
        }
    }
}