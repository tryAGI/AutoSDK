//HintName: G.Models.ResultWithContentVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResultWithContentVariant2
    {
        /// <summary>
        /// The full content text of the search result.<br/>
        /// Example: Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...
        /// </summary>
        /// <example>Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Array of highlights extracted from the search result content.<br/>
        /// Example: [Such requirements have limited their adoption...]
        /// </summary>
        /// <example>[Such requirements have limited their adoption...]</example>
        [global::Newtonsoft.Json.JsonProperty("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// Array of cosine similarity scores for each highlighted<br/>
        /// Example: [0.4600165784358978]
        /// </summary>
        /// <example>[0.4600165784358978]</example>
        [global::Newtonsoft.Json.JsonProperty("highlightScores")]
        public global::System.Collections.Generic.IList<float>? HighlightScores { get; set; }

        /// <summary>
        /// Summary of the webpage<br/>
        /// Example: This overview paper on Large Language Models (LLMs) highlights key developments...
        /// </summary>
        /// <example>This overview paper on Large Language Models (LLMs) highlights key developments...</example>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Array of subpages for the search result.<br/>
        /// Example: [{"id":"https://arxiv.org/abs/2303.17580","url":"https://arxiv.org/pdf/2303.17580.pdf","title":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face","author":"Yongliang  Shen, Microsoft Research Asia, Kaitao  Song, Microsoft Research Asia, Xu  Tan, Microsoft Research Asia, Dongsheng  Li, Microsoft Research Asia, Weiming  Lu, Microsoft Research Asia, Yueting  Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn, Zhejiang  University, Microsoft Research Asia, Microsoft  Research, Microsoft Research Asia","publishedDate":"2023-11-16T01:36:20.486Z","text":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face Date Published: 2023-05-25 Authors: Yongliang Shen, Microsoft Research Asia Kaitao Song, Microsoft Research Asia Xu Tan, Microsoft Research Asia Dongsheng Li, Microsoft Research Asia Weiming Lu, Microsoft Research Asia Yueting Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn Zhejiang University, Microsoft Research Asia Microsoft Research, Microsoft Research Asia Abstract Solving complicated AI tasks with different domains and modalities is a key step toward artificial general intelligence. While there are abundant AI models available for different domains and modalities, they cannot handle complicated AI tasks. Considering large language models (LLMs) have exhibited exceptional ability in language understanding, generation, interaction, and reasoning, we advocate that LLMs could act as a controller to manage existing AI models to solve complicated AI tasks and language could be a generic interface to empower t","summary":"HuggingGPT is a framework using ChatGPT as a central controller to orchestrate various AI models from Hugging Face to solve complex tasks. ChatGPT plans the task, selects appropriate models based on their descriptions, executes subtasks, and summarizes the results. This approach addresses limitations of LLMs by allowing them to handle multimodal data (vision, speech) and coordinate multiple models for complex tasks, paving the way for more advanced AI systems.","highlights":["2) Recently, some researchers started to investigate the integration of using tools or models in LLMs  ."],"highlightScores":[0.32679107785224915]}]
        /// </summary>
        /// <example>[{"id":"https://arxiv.org/abs/2303.17580","url":"https://arxiv.org/pdf/2303.17580.pdf","title":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face","author":"Yongliang  Shen, Microsoft Research Asia, Kaitao  Song, Microsoft Research Asia, Xu  Tan, Microsoft Research Asia, Dongsheng  Li, Microsoft Research Asia, Weiming  Lu, Microsoft Research Asia, Yueting  Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn, Zhejiang  University, Microsoft Research Asia, Microsoft  Research, Microsoft Research Asia","publishedDate":"2023-11-16T01:36:20.486Z","text":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face Date Published: 2023-05-25 Authors: Yongliang Shen, Microsoft Research Asia Kaitao Song, Microsoft Research Asia Xu Tan, Microsoft Research Asia Dongsheng Li, Microsoft Research Asia Weiming Lu, Microsoft Research Asia Yueting Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn Zhejiang University, Microsoft Research Asia Microsoft Research, Microsoft Research Asia Abstract Solving complicated AI tasks with different domains and modalities is a key step toward artificial general intelligence. While there are abundant AI models available for different domains and modalities, they cannot handle complicated AI tasks. Considering large language models (LLMs) have exhibited exceptional ability in language understanding, generation, interaction, and reasoning, we advocate that LLMs could act as a controller to manage existing AI models to solve complicated AI tasks and language could be a generic interface to empower t","summary":"HuggingGPT is a framework using ChatGPT as a central controller to orchestrate various AI models from Hugging Face to solve complex tasks. ChatGPT plans the task, selects appropriate models based on their descriptions, executes subtasks, and summarizes the results. This approach addresses limitations of LLMs by allowing them to handle multimodal data (vision, speech) and coordinate multiple models for complex tasks, paving the way for more advanced AI systems.","highlights":["2) Recently, some researchers started to investigate the integration of using tools or models in LLMs  ."],"highlightScores":[0.32679107785224915]}]</example>
        [global::Newtonsoft.Json.JsonProperty("subpages")]
        public global::System.Collections.Generic.IList<global::G.ResultWithContent>? Subpages { get; set; }

        /// <summary>
        /// Results from extras.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extras")]
        public global::G.ResultWithContentVariant2Extras? Extras { get; set; }

        /// <summary>
        /// Structured entity data for company or person search results. Only returned for category=company or category=people searches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities")]
        public global::System.Collections.Generic.IList<global::G.Entity>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultWithContentVariant2" /> class.
        /// </summary>
        /// <param name="text">
        /// The full content text of the search result.<br/>
        /// Example: Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...
        /// </param>
        /// <param name="highlights">
        /// Array of highlights extracted from the search result content.<br/>
        /// Example: [Such requirements have limited their adoption...]
        /// </param>
        /// <param name="highlightScores">
        /// Array of cosine similarity scores for each highlighted<br/>
        /// Example: [0.4600165784358978]
        /// </param>
        /// <param name="summary">
        /// Summary of the webpage<br/>
        /// Example: This overview paper on Large Language Models (LLMs) highlights key developments...
        /// </param>
        /// <param name="subpages">
        /// Array of subpages for the search result.<br/>
        /// Example: [{"id":"https://arxiv.org/abs/2303.17580","url":"https://arxiv.org/pdf/2303.17580.pdf","title":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face","author":"Yongliang  Shen, Microsoft Research Asia, Kaitao  Song, Microsoft Research Asia, Xu  Tan, Microsoft Research Asia, Dongsheng  Li, Microsoft Research Asia, Weiming  Lu, Microsoft Research Asia, Yueting  Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn, Zhejiang  University, Microsoft Research Asia, Microsoft  Research, Microsoft Research Asia","publishedDate":"2023-11-16T01:36:20.486Z","text":"HuggingGPT: Solving AI Tasks with ChatGPT and its Friends in Hugging Face Date Published: 2023-05-25 Authors: Yongliang Shen, Microsoft Research Asia Kaitao Song, Microsoft Research Asia Xu Tan, Microsoft Research Asia Dongsheng Li, Microsoft Research Asia Weiming Lu, Microsoft Research Asia Yueting Zhuang, Microsoft Research Asia, yzhuang@zju.edu.cn Zhejiang University, Microsoft Research Asia Microsoft Research, Microsoft Research Asia Abstract Solving complicated AI tasks with different domains and modalities is a key step toward artificial general intelligence. While there are abundant AI models available for different domains and modalities, they cannot handle complicated AI tasks. Considering large language models (LLMs) have exhibited exceptional ability in language understanding, generation, interaction, and reasoning, we advocate that LLMs could act as a controller to manage existing AI models to solve complicated AI tasks and language could be a generic interface to empower t","summary":"HuggingGPT is a framework using ChatGPT as a central controller to orchestrate various AI models from Hugging Face to solve complex tasks. ChatGPT plans the task, selects appropriate models based on their descriptions, executes subtasks, and summarizes the results. This approach addresses limitations of LLMs by allowing them to handle multimodal data (vision, speech) and coordinate multiple models for complex tasks, paving the way for more advanced AI systems.","highlights":["2) Recently, some researchers started to investigate the integration of using tools or models in LLMs  ."],"highlightScores":[0.32679107785224915]}]
        /// </param>
        /// <param name="extras">
        /// Results from extras.
        /// </param>
        /// <param name="entities">
        /// Structured entity data for company or person search results. Only returned for category=company or category=people searches.
        /// </param>
        public ResultWithContentVariant2(
            string? text,
            global::System.Collections.Generic.IList<string>? highlights,
            global::System.Collections.Generic.IList<float>? highlightScores,
            string? summary,
            global::System.Collections.Generic.IList<global::G.ResultWithContent>? subpages,
            global::G.ResultWithContentVariant2Extras? extras,
            global::System.Collections.Generic.IList<global::G.Entity>? entities)
        {
            this.Text = text;
            this.Highlights = highlights;
            this.HighlightScores = highlightScores;
            this.Summary = summary;
            this.Subpages = subpages;
            this.Extras = extras;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultWithContentVariant2" /> class.
        /// </summary>
        public ResultWithContentVariant2()
        {
        }
    }
}