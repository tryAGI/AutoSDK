//HintName: G.Models.ListFilesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFilesType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evaluator")]
        Evaluator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="flow")]
        Flow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFilesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesType value)
        {
            return value switch
            {
                ListFilesType.Agent => "agent",
                ListFilesType.Dataset => "dataset",
                ListFilesType.Evaluator => "evaluator",
                ListFilesType.Flow => "flow",
                ListFilesType.Prompt => "prompt",
                ListFilesType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ListFilesType.Agent,
                "dataset" => ListFilesType.Dataset,
                "evaluator" => ListFilesType.Evaluator,
                "flow" => ListFilesType.Flow,
                "prompt" => ListFilesType.Prompt,
                "tool" => ListFilesType.Tool,
                _ => null,
            };
        }
    }
}