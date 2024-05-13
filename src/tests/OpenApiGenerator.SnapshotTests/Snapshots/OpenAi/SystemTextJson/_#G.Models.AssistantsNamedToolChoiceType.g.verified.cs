//HintName: G.Models.AssistantsNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. If type is `function`, the function name must be set
    /// </summary>
    public abstract class AssistantsNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Function = "function";
        /// <summary>
        /// 
        /// </summary>
        public const string CodeInterpreter = "code_interpreter";
        /// <summary>
        /// 
        /// </summary>
        public const string FileSearch = "file_search";
    }
}