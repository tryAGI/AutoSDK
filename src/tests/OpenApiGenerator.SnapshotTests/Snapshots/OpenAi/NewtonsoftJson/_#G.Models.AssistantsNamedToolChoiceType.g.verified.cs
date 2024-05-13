//HintName: G.Models.AssistantsNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. If type is `function`, the function name must be set
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantsNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code_interpreter")]
        CodeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search")]
        FileSearch,
    }
}