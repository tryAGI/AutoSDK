//HintName: G.Models.FunctionTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of global function. Defaults to 'scorer'.<br/>
    /// Default Value: scorer
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifier")]
        Classifier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom_view")]
        CustomView,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="facet")]
        Facet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parameters")]
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preprocessor")]
        Preprocessor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sandbox")]
        Sandbox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scorer")]
        Scorer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="task")]
        Task,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionTypeEnum value)
        {
            return value switch
            {
                FunctionTypeEnum.Classifier => "classifier",
                FunctionTypeEnum.CustomView => "custom_view",
                FunctionTypeEnum.Facet => "facet",
                FunctionTypeEnum.Llm => "llm",
                FunctionTypeEnum.Parameters => "parameters",
                FunctionTypeEnum.Preprocessor => "preprocessor",
                FunctionTypeEnum.Sandbox => "sandbox",
                FunctionTypeEnum.Scorer => "scorer",
                FunctionTypeEnum.Tag => "tag",
                FunctionTypeEnum.Task => "task",
                FunctionTypeEnum.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "classifier" => FunctionTypeEnum.Classifier,
                "custom_view" => FunctionTypeEnum.CustomView,
                "facet" => FunctionTypeEnum.Facet,
                "llm" => FunctionTypeEnum.Llm,
                "parameters" => FunctionTypeEnum.Parameters,
                "preprocessor" => FunctionTypeEnum.Preprocessor,
                "sandbox" => FunctionTypeEnum.Sandbox,
                "scorer" => FunctionTypeEnum.Scorer,
                "tag" => FunctionTypeEnum.Tag,
                "task" => FunctionTypeEnum.Task,
                "tool" => FunctionTypeEnum.Tool,
                _ => null,
            };
        }
    }
}