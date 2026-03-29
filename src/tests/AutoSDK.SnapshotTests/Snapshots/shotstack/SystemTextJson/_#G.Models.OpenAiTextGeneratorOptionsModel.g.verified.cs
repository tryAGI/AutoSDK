//HintName: G.Models.OpenAiTextGeneratorOptionsModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model to use for generating the text. Select from the list of available models: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`gpt-3.5-turbo`&lt;/li&gt;<br/>
    ///   &lt;li&gt;`gpt-4`&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Example: gpt-4
    /// </summary>
    public enum OpenAiTextGeneratorOptionsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiTextGeneratorOptionsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiTextGeneratorOptionsModel value)
        {
            return value switch
            {
                OpenAiTextGeneratorOptionsModel.Gpt35Turbo => "gpt-3.5-turbo",
                OpenAiTextGeneratorOptionsModel.Gpt4 => "gpt-4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiTextGeneratorOptionsModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-3.5-turbo" => OpenAiTextGeneratorOptionsModel.Gpt35Turbo,
                "gpt-4" => OpenAiTextGeneratorOptionsModel.Gpt4,
                _ => null,
            };
        }
    }
}