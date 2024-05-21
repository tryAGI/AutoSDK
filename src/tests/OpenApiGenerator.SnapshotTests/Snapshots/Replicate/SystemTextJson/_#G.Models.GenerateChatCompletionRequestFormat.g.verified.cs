//HintName: G.Models.GenerateChatCompletionRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format to return a response in. Currently the only accepted value is json.
    /// Enable JSON mode by setting the format parameter to json. This will structure the response as valid JSON.
    /// Note: it's important to instruct the model to use JSON in the prompt. Otherwise, the model may generate large amounts whitespace.
    /// </summary>
    public abstract class GenerateChatCompletionRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Json = "json";
    }
}