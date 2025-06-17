﻿//HintName: G.Models.GenerateStreamTextVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamTextVariant2
    {
        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero, and only when text responses are being streamed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_finished", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinished { get; set; } = default!;

        /// <summary>
        /// A segment of text of the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamTextVariant2" /> class.
        /// </summary>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero, and only when text responses are being streamed.
        /// </param>
        /// <param name="isFinished"></param>
        /// <param name="text">
        /// A segment of text of the generation.
        /// </param>
        public GenerateStreamTextVariant2(
            bool isFinished,
            string text,
            int? index)
        {
            this.IsFinished = isFinished;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamTextVariant2" /> class.
        /// </summary>
        public GenerateStreamTextVariant2()
        {
        }
    }
}