//HintName: G.Models.CreateEditRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEditRequest
    {
        /// <summary>
        /// The instruction that tells the model how to edit the prompt.
        /// <br/>Example: Fix the spelling mistakes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instruction { get; set; } = default!;

        /// <summary>
        /// ID of the model to use. You can use the `text-davinci-edit-001` or `code-davinci-edit-001` model with this endpoint.
        /// <br/>Example: text-davinci-edit-001
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public object Model { get; set; } = default!;

        /// <summary>
        /// The input text to use as a starting point for the edit.
        /// <br/>Default Value: 
        /// <br/>Example: What day of the wek is it?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public string? Input { get; set; } = "";

        /// <summary>
        /// How many edits to generate for the input and instruction.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n")]
        public int? N { get; set; } = 1;

        /// <summary>
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// We generally recommend altering this or `top_p` but not both.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; } = 1;

        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        /// We generally recommend altering this or `temperature` but not both.
        /// <br/>Default Value: 1
        /// <br/>Example: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; } = 1;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}