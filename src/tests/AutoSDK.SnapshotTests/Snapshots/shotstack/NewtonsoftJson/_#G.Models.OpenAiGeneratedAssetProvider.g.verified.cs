//HintName: G.Models.OpenAiGeneratedAssetProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the provider - set to `openai` for OpenAI.<br/>
    /// Default Value: openai
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAiGeneratedAssetProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiGeneratedAssetProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiGeneratedAssetProvider value)
        {
            return value switch
            {
                OpenAiGeneratedAssetProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiGeneratedAssetProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAiGeneratedAssetProvider.Openai,
                _ => null,
            };
        }
    }
}