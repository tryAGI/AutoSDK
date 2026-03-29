//HintName: G.Models.CreateRequestLlmVariant6Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateRequestLlmVariant6Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateRequestLlmVariant6ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant6Provider value)
        {
            return value switch
            {
                CreateRequestLlmVariant6Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant6Provider? ToEnum(string value)
        {
            return value switch
            {
                "google" => CreateRequestLlmVariant6Provider.Google,
                _ => null,
            };
        }
    }
}