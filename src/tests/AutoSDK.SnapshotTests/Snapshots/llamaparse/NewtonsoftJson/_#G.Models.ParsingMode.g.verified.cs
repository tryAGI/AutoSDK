//HintName: G.Models.ParsingMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for representing the mode of parsing to be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ParsingMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_document_with_agent")]
        ParseDocumentWithAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_document_with_llm")]
        ParseDocumentWithLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_document_with_lvm")]
        ParseDocumentWithLvm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_page_with_agent")]
        ParsePageWithAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_page_with_layout_agent")]
        ParsePageWithLayoutAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_page_with_llm")]
        ParsePageWithLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_page_with_lvm")]
        ParsePageWithLvm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parse_page_without_llm")]
        ParsePageWithoutLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParsingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParsingMode value)
        {
            return value switch
            {
                ParsingMode.ParseDocumentWithAgent => "parse_document_with_agent",
                ParsingMode.ParseDocumentWithLlm => "parse_document_with_llm",
                ParsingMode.ParseDocumentWithLvm => "parse_document_with_lvm",
                ParsingMode.ParsePageWithAgent => "parse_page_with_agent",
                ParsingMode.ParsePageWithLayoutAgent => "parse_page_with_layout_agent",
                ParsingMode.ParsePageWithLlm => "parse_page_with_llm",
                ParsingMode.ParsePageWithLvm => "parse_page_with_lvm",
                ParsingMode.ParsePageWithoutLlm => "parse_page_without_llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParsingMode? ToEnum(string value)
        {
            return value switch
            {
                "parse_document_with_agent" => ParsingMode.ParseDocumentWithAgent,
                "parse_document_with_llm" => ParsingMode.ParseDocumentWithLlm,
                "parse_document_with_lvm" => ParsingMode.ParseDocumentWithLvm,
                "parse_page_with_agent" => ParsingMode.ParsePageWithAgent,
                "parse_page_with_layout_agent" => ParsingMode.ParsePageWithLayoutAgent,
                "parse_page_with_llm" => ParsingMode.ParsePageWithLlm,
                "parse_page_with_lvm" => ParsingMode.ParsePageWithLvm,
                "parse_page_without_llm" => ParsingMode.ParsePageWithoutLlm,
                _ => null,
            };
        }
    }
}